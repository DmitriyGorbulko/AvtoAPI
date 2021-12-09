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

        [HttpGet]
        public async Task<IActionResult> GetRudders()
        {
            return Ok(await _rudderService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] Rudder rudder)
        {
            return Ok(await _rudderService.Create(rudder));
        }

        [HttpDelete]
        public async Task Delete([FromQuery] int id)
        {
            await _rudderService.DeleteRudder(id);
        }

        [HttpPut]
        public async Task Update([FromQuery] Rudder rudder)
        {
            Ok(await _rudderService.UpdateRudder(rudder));
        }
    }
}