using System.Threading.Tasks;
using System.Threading;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    public interface ICreateRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> CreateAsync(TEntity subElement, CancellationToken cancellationToken);
    }
}
