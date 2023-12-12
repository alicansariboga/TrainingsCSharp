using Project14.Business.concrete;
using Project14.Data.concrete;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.ConsoleUI.methods
{
    public class MethodCustomer
    {
        // Adding operation to DB about Customer.
        CustomerManager customerManager = new CustomerManager(new CustomerDao());
        public MethodCustomer()
        {
            //customerManager.Add(new Customer { CustomerId = "TEST", CompanyName = "Test", ContactName = "Test" });
            
        }

        public void mCustomerGetAll()
        {
            foreach (var customer in customerManager.GetAll())
            {
                Console.WriteLine(customer.CompanyName + " and " + customer.ContactName);
            }
        }

        public void mCustomerAdd()
        {
            try
            {
                Console.WriteLine("Please enter the Customer's ID : ");
                var idCustomer = Console.ReadLine();
                Console.WriteLine("Please enter the Customer's Name : ");
                var companyNameCustomer = Console.ReadLine();
                Console.WriteLine("Please enter the Customer's Company Name : ");
                var contactNameCustomer = Console.ReadLine();
                customerManager.Add(new Customer { CustomerId = idCustomer, CompanyName = companyNameCustomer, ContactName = contactNameCustomer });
                Console.WriteLine("Adding operation was successfully.");
                Console.WriteLine("Added this : \n {0} / {1} / {2} ", idCustomer, companyNameCustomer, contactNameCustomer);
            }
            catch (Exception)
            {
                Console.WriteLine("There is an error.");
                throw;
            }
        }
    }
}
