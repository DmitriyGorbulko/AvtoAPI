using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Repositories
{
    public class PersonRepository : RepositoryBase<Person> , IPersonRepository
    {
        public PersonRepository(AvtoContext context) : base(context) 
        {}
    }
}
