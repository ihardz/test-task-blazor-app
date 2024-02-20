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

        public async Task<Window> CreateAsync(Window window, CancellationToken cancellationToken = default)
        {
            DbContext.Add(window);
            await DbContext.SaveChangesAsync();
            return window;
        }
    }
}
