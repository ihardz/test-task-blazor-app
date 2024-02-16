using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface IStateService
    {
        Task<IEnumerable<StateDto>> GetAsync(CancellationToken cancellationToken);
    }
}
