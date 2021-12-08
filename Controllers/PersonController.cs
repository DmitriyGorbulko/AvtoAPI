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
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return Ok(await _personService.GetPersonById(id));
        }
    }
}