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
    public class AvtoService : IAvtoService
    {
        private readonly IAvtoRepository _avtoRepository;
        private IAvtoService _avtoService;

        public async Task<Avto> Create(Avto avto)
        {
            return await _avtoRepository.Create(avto);
        }

        public async Task DeleteAvto(int id)
        {
            await _avtoRepository.DeleteAsync(id);
        }

        public async Task<List<Avto>> GetAll()
        {
            return await _avtoRepository.GetAll(avto);
        }

        public async Task<Avto> GetAvtoById(int id)
        {
            return await _avtoRepository.GetAsync(id);
        }

        public async Task<Avto> GetAvtoByNumberAvto(string numberAvto)
        {
            return await _avtoService.GetAvtoByNumberAvto(numberAvto);
        }

        public async Task UpdateAvto(Avto avto)
        {
            await _avtoRepository.UpdateAsync(avto) ;
        }
    }
}
