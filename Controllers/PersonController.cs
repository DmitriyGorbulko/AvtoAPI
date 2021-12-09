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

        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {
            return Ok(await _personService.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromQuery] BodyType person)
        {
            return Ok(await _personService.Create(person));
        }

        [HttpDelete]
        public async Task Delete([FromQuery] int id)
        {
            return Ok(await _personService.DeletePerson(id));
        }

        [HttpPut]
        public async Task Update([FromQuery] Person person)
        {
            return Ok(await _personService.UpdatePerson(person));
        }
    }
}