using System.Threading.Tasks;
using System.Threading;
using BlazorApp.DataAccess.Entities.Abstraction;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    public interface IUpsertDeleteRepository<TEntity> where TEntity : class, IEntity<int>, new()
    {
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
