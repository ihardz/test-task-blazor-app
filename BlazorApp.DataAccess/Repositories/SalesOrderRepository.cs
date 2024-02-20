using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories
{
    internal class SalesOrderRepository : SalesRepositoryBase, IOrderRepository
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
            var entity = await DbContext.Orders
                .Include(x => x.State)
                .Include(x => x.Windows).ThenInclude(x => x.SubElements)
                .Where(x => x.Id == id)
                .Take(1)
                .Select(x => new Order
                {
                    Id = x.Id,
                    Name = x.Name,
                    State = x.State,
                    StateId = x.StateId,
                    Windows = x.Windows.Select(x => new Window
                    {
                        Id = x.Id,
                        Name = x.Name,
                        OrderId = x.OrderId,
                        Quantity = x.Quantity,
                        SubElements = x.SubElements,
                        TotalSubElements = x.SubElements.Count()
                    })
                })
                .FirstOrDefaultAsync();

            return entity;
        }

        // TODO: add pagination
        public async Task<IEnumerable<Order>> GetAsync(CancellationToken cancellationToken = default)
        {
            var entities = await DbContext.Orders.ToListAsync(cancellationToken);
            return entities;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            var target = new Order { Id = id };
            DbContext.Orders.Attach(target);
            DbContext.Orders.Remove(target);
            await DbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateAsync(Order entity, CancellationToken cancellationToken = default)
        {
            DbContext.Orders.Update(entity);
            await DbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
