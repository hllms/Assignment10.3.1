using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10._3._1.Models;
using Assignment10._3._1.Data;
using Assignment10._3._1.Services;

namespace Assignment10._3._1.Data
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=JH-OMEN;initial catalog=CCAD20CAR;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { VIN = 1, Make = "Toyota", Model = "Camry", Year = 2020, Price = 24000 },
                new Car { VIN = 2, Make = "Honda", Model = "Civic", Year = 2019, Price = 22000 },
                new Car { VIN = 3, Make = "Ford", Model = "Mustang", Year = 2021, Price = 30000 }
            );
        }
    }
}
