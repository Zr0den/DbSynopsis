using Microsoft.AspNetCore.Mvc;
using SimpleApi.Entities;
using SimpleApi.Interfaces;
using SimpleApi.Services;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleObjectController : ControllerBase
    {
        private readonly ICreateObject _createObjectService;

        public SimpleObjectController(ICreateObject createObjectService)
        {
            _createObjectService = createObjectService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] SimpleObject simpleObject)
        {
            var createdObject = await _createObjectService.CreateAsync(simpleObject);
            return Ok(createdObject);
        }
    }
}
