using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvtoAPI.Models;
using AvtoAPI.Entities;

namespace AvtoAPI.Entities
{
    public class AvtoContext : DbContext
    {
        public AvtoContext(DbContextOptions<AvtoContext> options)
            : base(options)
        {
        }
        public DbSet<Avto> Avtos { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Rudder> Rudders { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<BrandModel> BrandModel { get; set; }
        public DbSet<ColorAvto> ColorAvto { get; set; }
      
    }
}
