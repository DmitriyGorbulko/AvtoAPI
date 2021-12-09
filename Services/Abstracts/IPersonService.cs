using AvtoAPI.Entities;
using AvtoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IPersonService
    {
        Task<Person> GetPersonById(int id);
        Task<IEnumerable<Person>> GetAll();
        Task<Person> Create(Person person);
        Task<Person> UpdatePerson(Person person);
        Task DeletePerson(int id);
    }
}
