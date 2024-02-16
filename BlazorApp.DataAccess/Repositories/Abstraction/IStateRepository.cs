using BlazorApp.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetAsync(CancellationToken cancellationToken = default);
    }
}
