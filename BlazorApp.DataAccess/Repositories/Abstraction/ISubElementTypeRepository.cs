using BlazorApp.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    public interface ISubElementTypeRepository
    {
        Task<IEnumerable<SubElementType>> GetAsync(CancellationToken cancellationToken = default);
    }
}
