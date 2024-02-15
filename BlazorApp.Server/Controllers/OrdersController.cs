using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.Server.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IUriResolver _uriResolver;

        public OrdersController(IOrderService orderService, IUriResolver uriResolver)
        {
            _orderService = orderService;
            _uriResolver = uriResolver;
        }

        [HttpGet]
        public IEnumerable<OrderDto> Get()
        {
            return null;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var orderDto = await _orderService.GetByIdAsync(id, cancellationToken);
            return Ok(orderDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderUpsertDto orderCreateDto, CancellationToken cancellationToken)
        {
            var orderDto = await _orderService.CreateAsync(orderCreateDto, cancellationToken);
            var uri = _uriResolver.Order(orderDto.Id);
            return Created(uri, orderDto);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] OrderUpsertDto dto)
        {
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _orderService.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
