using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface IOrderService
    {
        Task<int> CreateAsync(OrderUpsertDto orderUpsertDto, CancellationToken cancellationToken = default);
        Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    }
}
