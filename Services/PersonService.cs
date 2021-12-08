using AvtoAPI.Entities;
using AvtoAPI.Models;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public async Task<Person> Create(Person person)
        {
            return await _personRepository.Create(person);
        }

        public async Task DeletePerson(int id)
        {
            await _personRepository.DeleteAsync(id);
        }

        public async Task<List<Person>> GetAll()
        {
            return await _personRepository.GetAll(new List<Person>);
        }

        public async Task<Person> GetPersonById(int id)
        {
            return await _personRepository.GetAsync(id);
        }

        public async Task UpdatePerson(Person person)
        {
            await _personRepository.UpdateAsync(person);
        }
    }
}
