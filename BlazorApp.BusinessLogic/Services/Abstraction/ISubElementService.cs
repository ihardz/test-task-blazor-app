using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface ISubElementService
    {
        Task<SubElementDto> CreateAsync(SubElementUpsertDto createDto, CancellationToken cancellationToken = default);
    }
}
