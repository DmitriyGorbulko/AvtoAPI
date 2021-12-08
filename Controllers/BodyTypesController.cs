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
    public class BodyTypeController : ControllerBase
    {
        private readonly IBodyTypeService _bodyTypeService;

        public BodyTypeController(IBodyTypeService bodyTypeService)
        {
            _bodyTypeService = bodyTypeService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAvto([FromQuery] int id)
        {
            return Ok(await _bodyTypeService.GetBodyTypeById(id));
        }
    }
}