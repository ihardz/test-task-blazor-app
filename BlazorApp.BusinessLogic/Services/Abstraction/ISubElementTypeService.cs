using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface ISubElementTypeService
    {
        Task<IEnumerable<SubElementTypeDto>> GetAsync(CancellationToken cancellationToken);
    }
}
