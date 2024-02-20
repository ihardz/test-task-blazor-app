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
    public class SubElementsController : ControllerBase
    {
        private readonly IUriResolver _uriResolver;
        private readonly ISubElementService _service;

        public SubElementsController(ISubElementService service, IUriResolver uriResolver)
        {
            _service = service;
            _uriResolver = uriResolver;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SubElementDto createDto, CancellationToken cancellationToken)
        {
            var created = await _service.CreateAsync(createDto, cancellationToken);
            var uri = _uriResolver.SubElement(created.Id);
            return Created(uri, created);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] SubElementDto dto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
