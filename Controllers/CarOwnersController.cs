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
    public class CarOwnerController : ControllerBase
    {
        private readonly ICarOwnerService _carOwnerService;

        public CarOwnerController(ICarOwnerService carOwnerService)
        {
            _carOwnerService = carOwnerService;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _carOwnerService.GetCarOwnerById(id));
        }
    }
}