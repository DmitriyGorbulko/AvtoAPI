﻿using AvtoAPI.Entities;
using AvtoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IRudderService
    {
        Task<Rudder> GetRudderById(int id);
        Task<List<Rudder>> GetAll();
        Task<Rudder> Create(Rudder rudder);
        Task UpdateRudder(Rudder rudder);
        Task DeleteRudder(int id);
    }
}
