using Project13.Data.@abstract;
using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Data.concrete
{
    public class CarDao : ICarDao
    {
        public List<Car> _cars;
        public CarDao()
        {
            _cars = new List<Car>()
            {
                new Car{ CarId=1, CarBrand="Mercedes", CarModel="GLA", CarProductionYear=2019, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=2, CarBrand="Mercedes", CarModel="AMG", CarProductionYear=2021, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=3, CarBrand="BMW", CarModel="520d", CarProductionYear=2018, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=4, CarBrand="AUDI", CarModel="A7", CarProductionYear=2020, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=5, CarBrand="AUDI", CarModel="Q8", CarProductionYear=2022, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=6, CarBrand="Range Rover", CarModel="Velar", CarProductionYear=2021, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=7, CarBrand="Porche", CarModel="Taycan", CarProductionYear=2023, CarSaleCost=2000000, CarRentCost=5000 },
                new Car{ CarId=8, CarBrand="Porche", CarModel="Cayman", CarProductionYear=2022, CarSaleCost=2000000, CarRentCost=5000 }
            };
        }
        public void Add(Car car)
        {
            Console.WriteLine("Added to DB.");
        }
        public void Update(Car car) 
        {
            Console.WriteLine("Updated on DB.");
        }
        public void Delete(Car car) 
        {
            Console.WriteLine("Deleted from DB.");
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }
    }
}
