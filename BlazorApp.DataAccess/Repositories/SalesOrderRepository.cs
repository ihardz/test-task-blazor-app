using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories
{
    internal class SalesOrderRepository: SalesRepositoryBase, IOrderRepository
    {
        public SalesOrderRepository(SalesDbContext dbContext) : base(dbContext) { }

        public async Task<Order> CreateAsync(Order entity, CancellationToken cancellationToken = default)
        {
            DbContext.Orders.Add(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public async Task<Order> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await DbContext.Orders.FindAsync(id, cancellationToken);
            return entity;
        }
    }
}
