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
    [ApiController]
    public class AvtoController : ControllerBase
    {
        private readonly IAvtoService _avtoService;

        public AvtoController(IAvtoService avtoService)
        {
            _avtoService = avtoService;
        }


        [HttpGet]
        public async Task<IActionResult> GetAvto([FromQuery] int id)
        {
            return Ok(await _avtoService.GetAvtoById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetByNumberAvto([FromQuery] string numberAvto)
        {
            return Ok(await _avtoService.GetByNumberAvto(numberAvto));
        }

        [HttpGet]
        public async Task<IActionResult> GetAvtos()
        {
            return Ok(await _avtoService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] Avto avto)
        {
            return Ok(await _avtoService.Create(avto));
        }

        [HttpDelete]
        public async Task Delete([FromQuery] int id)
        {
            await _avtoService.DeleteAvto(id);
        }

        [HttpPut]
        public async Task Update ([FromQuery] Avto avto)
        {
            Ok(await _avtoService.UpdateAvto(avto));
        }
    }
}