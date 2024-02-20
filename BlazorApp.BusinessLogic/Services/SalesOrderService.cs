using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services
{
    internal class SalesOrderService : UpsertDeleteServiceBase<IOrderRepository, Order, OrderUpsertDto, OrderDto>, IOrderService
    {
        public SalesOrderService(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
        {
            Repository = orderRepository;
        }

        public async Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            var entity = await Repository.GetByIdAsync(id, cancellationToken);
            return Mapper.Map<OrderDto>(entity);
        }

        public async Task<IEnumerable<OrderDto>> GetAsync(CancellationToken cancellationToken = default)
        {
            var entities = await Repository.GetAsync(cancellationToken);
            var dtos = entities.Select(Mapper.Map<OrderDto>);
            return dtos;
        }

        public async Task DeleteAsync(int id, CancellationToken cancellationToken = default)
        {
            await Repository.DeleteAsync(id, cancellationToken);
        }
    }
}
