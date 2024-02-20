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

        public async Task<SubElement> CreateAsync(SubElement subElement, CancellationToken cancellationToken)
        {
            DbContext.Add(subElement);
            await DbContext.SaveChangesAsync(cancellationToken);
            return subElement;
        }
    }
}
