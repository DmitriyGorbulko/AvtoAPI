using AvtoAPI.Entities;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Controllers
{
    public class RudderController : ControllerBase
    {
        private readonly IRudderService _rudderService;

        public RudderController(IRudderService rudderService)
        {
            _rudderService = rudderService;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _rudderService.GetRudderById(id));
        }
    }
}