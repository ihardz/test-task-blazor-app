using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.Server.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
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
        private readonly IOrderService _service;
        private readonly IUriResolver _uriResolver;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IOrderService service, IUriResolver uriResolver, ILogger<OrdersController> logger)
        {
            _service = service;
            _uriResolver = uriResolver;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get(CancellationToken cancellationToken)
        {
            IEnumerable<OrderDto> result;
            try
            {
                result = await _service.GetAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                var message = $"Unable to get orders.";
                _logger.LogCritical(ex, message);
                return Problem(message);
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            OrderDto result;
            try
            {
                result = await _service.GetByIdAsync(id, cancellationToken);
            }
            catch (Exception ex)
            {
                var message = $"Unable to get order by id: {id}.";
                _logger.LogCritical(ex, message);
                return Problem(message);
            }

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderUpsertDto orderCreateDto, CancellationToken cancellationToken)
        {
            var orderDto = await _service.CreateAsync(orderCreateDto, cancellationToken);
            var uri = _uriResolver.Order(orderDto.Id);
            return Created(uri, orderDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] OrderUpsertDto dto)
        {
            await _service.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _service.DeleteAsync(id, cancellationToken);
            return NoContent();
        }
    }
}
