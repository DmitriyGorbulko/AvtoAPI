using AvtoAPI.Entities;
using AvtoAPI.Repositories;
using AvtoAPI.Services;
using AvtoAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Controllers
{
    [ApiController]
    public class BodyTypeController : ControllerBase
    {
        private readonly IBodyTypeService _bodyTypeService;

        public BodyTypeController(IBodyTypeService bodyTypeService)
        {
            _bodyTypeService = bodyTypeService;
        }


        [HttpGet]
        [Route(nameof(GetBodyType))]
        public async Task<IActionResult> GetBodyType([FromQuery] int id)
        {
            return Ok(await _bodyTypeService.GetBodyTypeById(id));
        }

        [HttpGet]
        [Route(nameof(GetBodyTypes))]
        public async Task<IActionResult> GetBodyTypes()
        {
            return Ok(await _bodyTypeService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreateBodyType))]
        public async Task<IActionResult> CreateBodyType([FromQuery] BodyType bodyType)
        {
            return Ok(await _bodyTypeService.Create(bodyType));
        }

        [HttpDelete]
        [Route(nameof(DeleteBodyType))]
        public async Task DeleteBodyType([FromQuery] int id)
        {
            await _bodyTypeService.DeleteBodyType(id);
        }

        [HttpPut]
        [Route(nameof(UpdateBodyType))]
        public async Task UpdateBodyType([FromQuery] BodyType bodyType)
        {
            Ok(await _bodyTypeService.UpdateBodyType(bodyType));
        }
    }
}