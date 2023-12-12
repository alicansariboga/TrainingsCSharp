using Project14.Business.concrete;
using Project14.ConsoleUI.methods;
using Project14.Data.concrete;
using Project14.Entities;
using System;
using System.Diagnostics.SymbolStore;

namespace Project14.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creatings
            MethodCustomer mCustomer = new MethodCustomer();
            ProductManager productManager = new ProductManager(new ProductDao());

            // Console.WriteLine(productManager.GetAll().Count);
            // I have a "Data is null." error. I think that It is about DB.

            EmployeeManager employeeManager = new EmployeeManager(new EmployeeDao());
            foreach (var employee in employeeManager.GetAll())
            {
                Console.WriteLine(" {0} / {1} / {2} ", employee.EmployeeId, employee.FirstName, employee.LastName);
            }

            //mCustomer.mCustomerGetAll();
            mCustomer.mCustomerAdd();
        }
    }
}
