using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories
{
    internal class SalesWindowRepository : SalesRepositoryBase, IWindowRepository
    {
        public SalesWindowRepository(SalesDbContext dbContext) : base(dbContext) { }

        public async Task<Window> CreateAsync(Window entity, CancellationToken cancellationToken = default)
        {
            DbContext.Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var target = new Window { Id = id };
            DbContext.Windows.Attach(target);
            DbContext.Windows.Remove(target);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Window entity, CancellationToken cancellationToken = default)
        {
            DbContext.Windows.Update(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
