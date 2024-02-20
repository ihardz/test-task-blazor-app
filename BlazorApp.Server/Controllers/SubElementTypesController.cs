using BlazorApp.BusinessLogic.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubElementTypesController : ControllerBase
    {
        private readonly ISubElementTypeService _service;

        public SubElementTypesController(ISubElementTypeService subElementTypeService)
        {
            _service = subElementTypeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync(CancellationToken cancellationToken)
        {
            var items = await _service.GetAsync(cancellationToken);
            return Ok(items);
        }
    }
}
