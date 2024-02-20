using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.State;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services
{
    internal class StateService : MapperServiceBase, IStateService
    {
        private readonly IStateRepository _stateRepository;

        public StateService(IStateRepository stateRepository, IMapper mapper): base(mapper) 
        {
            _stateRepository = stateRepository;
        }
        public async Task<IEnumerable<StateDto>> GetAsync(CancellationToken cancellationToken)
        {
            var entities = await _stateRepository.GetAsync(cancellationToken);
            var dtos = entities.Select(Mapper.Map<StateDto>);
            return dtos;
        }
    }
}
