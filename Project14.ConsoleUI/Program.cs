using Project14.Business.concrete;
using Project14.Data.concrete;
using System;

namespace Project14.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new ProductDao());
            //Console.WriteLine(productManager.GetAll().Count);
            
            EmployeeManager employeeManager = new EmployeeManager(new EmployeeDao());
            foreach (var employee in employeeManager.GetAll())
            {
                Console.WriteLine(" {0} / {1} / {2} ",employee.EmployeeId, employee.FirstName, employee.LastName);
            }
        }
    }
}
