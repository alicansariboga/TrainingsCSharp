using Project13.Business;
using Project13.Business.concrete;
using Project13.Data.concrete;
using Project13.Entity;
using System;

namespace Project13.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDao());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarModel + " - " + car.CarBrand);
            }
            try
            {
                carManager.Add(new Car { CarId = -10, CarBrand = "Test", CarModel = "Test", CarProductionYear = 1, CarRentCost = 1, CarSaleCost = 1 });
            }
            catch (ServiceMsgException exception)
            {
                Console.WriteLine (exception.Message);
            }
        }
    }
}
