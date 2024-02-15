using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services
{
    internal class SalesOrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public SalesOrderService(IOrderRepository orderRepository, IMapper mapper)
        {            
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> CreateAsync(OrderUpsertDto orderUpsertDto, CancellationToken cancellationToken = default)
        {
            var create = _mapper.Map<Order>(orderUpsertDto);
            var entity = await _orderRepository.CreateAsync(create, cancellationToken);
            return entity.Id;
        }

        public async Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await _orderRepository.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<OrderDto>(entity);
        }
    }
}
