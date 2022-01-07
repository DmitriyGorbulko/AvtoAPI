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

        /*protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Brand>().HasData(
                new Brand[]
                {
                    new Brand{ Name = "Mercedes"},
                    new Brand{ Name = "BMW"},
                    new Brand{ Name="KIA"}
                });
            *//*builder.Entity<BrandModel>().HasData(
                new BrandModel[]
                {
                    new BrandModel{ Name = "c63", BrandId = 1},
                    new BrandModel{ Name = "m5", BrandId = 2},
                    new BrandModel{ Name="k5", BrandId = 3}
                });*//*
            builder.Entity<ColorAvto>().HasData(
                new ColorAvto[]
                {
                    new ColorAvto{ Name = "Синий"},
                    new ColorAvto{ Name = "Красный"},
                    new ColorAvto{ Name="Белый"}
                });
            builder.Entity<Rudder>().HasData(
                new Rudder[]
                {
                    new Rudder{ Name = "Левый"},
                    new Rudder{ Name = "Правый"},
                });
            builder.Entity<BodyType>().HasData(
                new BodyType[]
                {
                    new BodyType{ Name = "Седан"},
                    new BodyType{ Name = "Хэтчбэк"},
                    new BodyType{ Name="Купе"}
                });
            *//*builder.Entity<CarOwner>().HasData(
                new CarOwner[]
                {
                    new CarOwner{ PersonId = 1, AvtoId = 1},
                    new CarOwner{ PersonId = 2, AvtoId = 2},
                    new CarOwner{ PersonId = 3, AvtoId = 3}
                });*/
            /*builder.Entity<Avto>().HasData(
                new Avto[]
                {
                    new Avto{ BodyTypeId = 1, BrandModelId = 1, ColorId = 1, RudderId = 1, NumberAvto = "а111аа11", Year = 2001, Vin = "1111111111", Power = 111},
                    new Avto{ BodyTypeId = 2, BrandModelId = 2, ColorId = 2, RudderId = 2, NumberAvto = "а222аа22", Year = 2002, Vin = "2211111111", Power = 222},
                    new Avto{ BodyTypeId = 3, BrandModelId = 3, ColorId = 3, RudderId = 1, NumberAvto = "а333аа33", Year = 2003, Vin = "3311111111", Power = 333}
                });*//*
        }*/
    }
}
