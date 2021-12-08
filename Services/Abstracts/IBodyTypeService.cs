using AvtoAPI.Entities;
using AvtoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IBodyTypeService
    {
        Task<BodyType> GetBodyTypeById(int id);
        Task<List<BodyType>> GetAll();
        Task<BodyType> Create(BodyType bodyType);
        Task UpdateBodyType(BodyType bodyType);
        Task DeleteBodyType(int id);
    }
}
