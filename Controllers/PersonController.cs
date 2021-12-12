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
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet]
        [Route(nameof(GetPerson))]
        public async Task<IActionResult> GetPerson([FromQuery] int id)
        {
            return Ok(await _personService.GetPersonById(id));
        }

        [HttpGet]
        [Route(nameof(GetPeople))]
        public async Task<IActionResult> GetPeople()
        {
            return Ok(await _personService.GetAll());
        }

        [HttpPost]
        [Route(nameof(CreatePerson))]
        public async Task<IActionResult> CreatePerson([FromQuery] Person person)
        {
            return Ok(await _personService.Create(person));
        }

        [HttpDelete]
        [Route(nameof(DeletePerson))]
        public async Task DeletePerson([FromQuery] int id)
        {
            await _personService.DeletePerson(id);
        }

        [HttpPut]
        [Route(nameof(UpdatePerson))]
        public async Task UpdatePerson([FromQuery] Person person)
        {
            Ok(await _personService.UpdatePerson(person));
        }
    }
}