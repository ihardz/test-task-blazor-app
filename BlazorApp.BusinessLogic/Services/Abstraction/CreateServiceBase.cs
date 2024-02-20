using AutoMapper;
using BlazorApp.DataAccess.Repositories.Abstraction;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    internal abstract class CreateServiceBase<TCreateRepository, TEntity, TUpsertDto, TDto> : MapperServiceBase 
        where TCreateRepository : ICreateRepository<TEntity>
        where TEntity : class, new()
        where TUpsertDto : class, new()
        where TDto : class, new()
    {
        protected TCreateRepository Repository { get; set; }
        protected CreateServiceBase(TCreateRepository repository, IMapper mapper) : base(mapper)
        {
            Repository = repository;
        }

        public async Task<TDto> CreateAsync(TUpsertDto orderUpsertDto, CancellationToken cancellationToken = default)
        {
            var create = Mapper.Map<TEntity>(orderUpsertDto);
            var entity = await Repository.CreateAsync(create, cancellationToken);
            return Mapper.Map<TDto>(entity);
        }
    }
}
