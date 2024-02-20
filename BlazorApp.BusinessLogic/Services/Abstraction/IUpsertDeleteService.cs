using System.Threading.Tasks;
using System.Threading;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface IUpsertDeleteService<TUpsertDto, TDto>
        where TUpsertDto : class, new()
        where TDto : class, new()
    {
        Task<TDto> CreateAsync(TUpsertDto createDto, CancellationToken cancellationToken = default);
        Task UpdateAsync(int id, TUpsertDto orderUpsertDto, CancellationToken cancellationToken = default);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
