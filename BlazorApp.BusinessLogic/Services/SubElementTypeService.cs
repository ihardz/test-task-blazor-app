using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services
{
    internal class SubElementTypeService : MapperServiceBase, ISubElementTypeService
    {
        private readonly ISubElementTypeRepository _repository;

        public SubElementTypeService(ISubElementTypeRepository repository, IMapper mapper) : base(mapper)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SubElementTypeDto>> GetAsync(CancellationToken cancellationToken)
        {
            var entities = await _repository.GetAsync(cancellationToken);
            var dtos = entities.Select(Mapper.Map<SubElementTypeDto>);
            return dtos;
        }
    }
}
