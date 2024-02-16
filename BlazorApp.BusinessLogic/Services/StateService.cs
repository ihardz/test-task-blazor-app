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
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;
        private readonly IMapper _mapper;

        public StateService(IStateRepository stateRepository, IMapper mapper)
        {
            _stateRepository = stateRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<StateDto>> GetAsync(CancellationToken cancellationToken)
        {
            var entities = await _stateRepository.GetAsync(cancellationToken);
            var dtos = entities.Select(_mapper.Map<StateDto>);
            return dtos;
        }
    }
}
