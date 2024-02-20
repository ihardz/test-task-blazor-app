using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.Clients.Abstraction
{
    public interface ISubElementTypeClient
    {
        Task<IEnumerable<SubElementTypeDto>> GetSubElementTypesAsync(CancellationToken cancellationToken = default);
    }

}
