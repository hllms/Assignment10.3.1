using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment10._3._1.Models;
using Assignment10._3._1.Data;

namespace Assignment10._3._1.Services
{
    public class CRUD
    {
        public void AddCar(Car car)
        {
            Records.context.Cars.Add(car);
            Records.context.SaveChanges();
        }

        public List<Car> GetAllCars()
        {
            return Records.context.Cars.ToList();
        }
        public Car GetCarByVIN(int vin)
        {
            return Records.context.Cars.Find(vin);
        }

        public void UpdateCar(Car car)
        {
            var existingCar = Records.context.Cars.Find(car.VIN);
            if (existingCar != null)
            {
                existingCar.Make = car.Make;
                existingCar.Model = car.Model;
                existingCar.Year = car.Year;
                existingCar.Price = car.Price;
                Records.context.SaveChanges();
            }
        }

        public void DeleteCar(int vin)
        {
            var car = Records.context.Cars.Find(vin);
            if (car != null)
            {
                Records.context.Cars.Remove(car);
                Records.context.SaveChanges();
            }
        }

        public int GetNextVIN()
        {
            if (Records.context.Cars.Any())
            {
                return Records.context.Cars.Max(c => c.VIN) + 1;
            }
            return 1;
        }

    }
}
