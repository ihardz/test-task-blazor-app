using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories
{
    internal class SubElementRepository : SalesRepositoryBase, ISubElementRepository
    {
        public SubElementRepository(SalesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<SubElement> CreateAsync(SubElement subElement, CancellationToken cancellationToken = default)
        {
            DbContext.Add(subElement);
            await DbContext.SaveChangesAsync(cancellationToken);
            return subElement;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var target = new SubElement { Id = id };
            DbContext.SubElements.Attach(target);
            DbContext.SubElements.Remove(target);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(SubElement entity, CancellationToken cancellationToken = default)
        {
            DbContext.SubElements.Update(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
