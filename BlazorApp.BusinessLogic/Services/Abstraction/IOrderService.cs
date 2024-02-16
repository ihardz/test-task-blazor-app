using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface IOrderService
    {
        Task<OrderDto> CreateAsync(OrderUpsertDto orderUpsertDto, CancellationToken cancellationToken = default);
        Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<OrderDto>> GetAsync(CancellationToken cancellationToken = default);
        Task Delete(int id, CancellationToken cancellationToken = default);
    }
}
