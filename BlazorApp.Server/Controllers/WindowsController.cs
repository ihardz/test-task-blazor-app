using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using BlazorApp.Server.Services.Abstraction;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowsController : ControllerBase
    {
        private readonly IWindowService _service;
        private readonly IUriResolver _uriResolver;

        public WindowsController(IWindowService service, IUriResolver uriResolver)
        {
            _service = service;
            _uriResolver = uriResolver;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WindowUpsertDto createDto, CancellationToken cancellationToken)
        {
            var created = await _service.CreateAsync(createDto, cancellationToken);
            var uri =_uriResolver.Window(created.Id);
            return Created(uri, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] WindowUpsertDto updateDto, CancellationToken cancellationToken)
        {
            await _service.UpdateAsync(id, updateDto, cancellationToken);
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
