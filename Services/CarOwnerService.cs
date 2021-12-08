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
    public class CarOwnerService : ICarOwnerService
    {
        private readonly ICarOwnerRepository _carOwnerRepository;

        public async Task<CarOwner> Create(CarOwner carOwner)
        {
            return await _carOwnerRepository.Create(carOwner);
        }

        public async Task DeleteCarOwner(int id)
        {
            await _carOwnerRepository.DeleteAsync(id);
        }

        public async Task<List<CarOwner>> GetAll()
        {
            return await _carOwnerRepository.GetAll(new List<CarOwner>);
        }

        public async Task<CarOwner> GetCarOwnerById(int id)
        {
            return await _carOwnerRepository.GetAsync(id);
        }

        public async Task UpdateCarOwner(CarOwner carOwner)
        {
            await _carOwnerRepository.UpdateAsync(carOwner);
        }
    }
}
