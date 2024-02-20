using AutoMapper;
using BlazorApp.DataAccess.Entities.Abstraction;
using BlazorApp.DataAccess.Repositories.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    internal abstract class UpsertDeleteServiceBase<TRepository, TEntity, TUpsertDto, TDto> : MapperServiceBase 
        where TRepository : IUpsertDeleteRepository<TEntity>
        where TEntity : class, IEntity<int>, new()
        where TUpsertDto : class, new()
        where TDto : class, new()
    {
        protected TRepository Repository { get; set; }
        protected UpsertDeleteServiceBase(TRepository repository, IMapper mapper) : base(mapper)
        {
            Repository = repository;
        }

        public async Task<TDto> CreateAsync(TUpsertDto orderUpsertDto, CancellationToken cancellationToken = default)
        {
            var create = Mapper.Map<TEntity>(orderUpsertDto);
            var entity = await Repository.CreateAsync(create, cancellationToken);
            return Mapper.Map<TDto>(entity);
        }

        public async Task UpdateAsync(int id, TUpsertDto upsertDto, CancellationToken cancellationToken = default)
        {
            var updatedEntity = Mapper.Map<TEntity>(upsertDto);
            updatedEntity.Id = id;
            await Repository.UpdateAsync(updatedEntity, cancellationToken);
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            await Repository.DeleteAsync(id, cancellationToken);
        }
    }
}
