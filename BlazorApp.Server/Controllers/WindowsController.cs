using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using System;
using BlazorApp.Server.Services.Abstraction;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WindowsController : ControllerBase
    {
        private readonly IWindowService _windowService;
        private readonly IUriResolver _uriResolver;

        public WindowsController(IWindowService windowService, IUriResolver uriResolver)
        {
            _windowService = windowService;
            _uriResolver = uriResolver;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] WindowUpsertDto createDto, CancellationToken cancellationToken)
        {
            var created = await _windowService.CreateAsync(createDto, cancellationToken);
            var uri =_uriResolver.Window(created.Id);
            return Created(uri, created);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] WindowUpsertDto dto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
