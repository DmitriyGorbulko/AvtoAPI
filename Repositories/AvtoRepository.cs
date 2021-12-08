using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvtoAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvtoAPI.Repositories
{
    public class AvtoRepository : RepositoryBase<Avto>, IAvtoRepository
    {
        public AvtoRepository(AvtoContext context): base(context)
        {}
    }
}
