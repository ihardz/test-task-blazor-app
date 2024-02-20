using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Clients.Abstraction
{
    public interface IStateClient
    {
        Task<IEnumerable<StateDto>> GetStatesAsync(CancellationToken cancellationToken = default);
    }
}
