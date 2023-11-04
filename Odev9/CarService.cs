using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev9
{
    class CarService
    {
        List<Car> carList;
        //Constructor
        public CarService()
        {
            carList = new List<Car>() 
            { 
                new Car { Id = 1, Brand = "Audi", Model = "A6", Power = 150, Cost = 4000 },
                new Car { Id = 2, Brand = "Mercedes", Model = "AMG", Power = 200, Cost = 4000 },
                new Car { Id = 3, Brand = "BMW", Model = "5.20d", Power = 180, Cost = 4000 },
                new Car { Id = 4, Brand = "Jaguar", Model = "X-Type", Power = 220, Cost = 5000 }
            };
        }

        public List<Car> GetAll()
        {
            return carList;
        }

        public void Add(Car car)
        {
            carList.Add(car);
        }
    }
}
