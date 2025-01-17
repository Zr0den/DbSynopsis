﻿using Microsoft.AspNetCore.Mvc;
using SimpleApi.Entities;
using SimpleApi.Services;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleObjectController : ControllerBase
    {
        private readonly CreateObject _createObjectService;
        private readonly GetObject _getObjectService;

        public SimpleObjectController(CreateObject createObjectService, GetObject getObjectService)
        {
            _createObjectService = createObjectService;
            _getObjectService = getObjectService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] SimpleObject simpleObject)
        {
            var createdObject = await _createObjectService.CreateAsync(simpleObject);
            return Ok(createdObject);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var simpleObjects = await _getObjectService.GetAllAsync();
            return Ok(simpleObjects);
        }

        [HttpGet("getSafe")]
        public async Task<IActionResult> GetByIdSafe(string id)
        {
            if (Int32.TryParse(id, out int verifiedId))
            {
                var simpleObjects = await _getObjectService.GetByIdSafeAsync(verifiedId);
                return Ok(simpleObjects);
            }
            return BadRequest();
        }

        [HttpGet("getUnsafe")]
        public async Task<IActionResult> GetByIdUnsafe(string id)
        {
            var simpleObjects = await _getObjectService.GetByIdUnsafeAsync(id);
            return Ok(simpleObjects);
        }

    }
}
