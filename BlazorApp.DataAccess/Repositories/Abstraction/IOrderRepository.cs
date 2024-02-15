using BlazorApp.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    public interface IOrderRepository
    {
        Task<Order> CreateAsync(Order order, CancellationToken cancellationToken = default);
        Task<Order> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Order>> GetAsync(CancellationToken cancellationToken = default);
        Task Delete(int id, CancellationToken cancellationToken = default);
    }
}
