using Project13.Data.@abstract;
using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Data.concrete
{
    public class CustomerDao : ICustomerDao
    {
        public List<Customer> _customer;
        public CustomerDao()
        {
            _customer = new List<Customer>()
            {
                new Customer { Id = 1, NationalIdentity = 14314135311, FirstName = "Customer", LastName = "Seller", City = "Adana", CustomerStatus = "seller" },
                new Customer { Id = 2, NationalIdentity = 14318942650, FirstName = "Customer", LastName = "Lodger", City = "Adana", CustomerStatus = "Lodger" },
                new Customer { Id = 3, NationalIdentity = 14318948741, FirstName = "Customer", LastName = "Purchaser", City = "Adana", CustomerStatus = "Purchaser" }
            };
        }

        public void Add(Customer entity)
        {
            Console.WriteLine("Added to DB.");
        }

        public void Delete(Customer entity)
        {
            Console.WriteLine("Deleted from DB.");
        }

        public List<Customer> GetAll()
        {
            return _customer;
        }

        public List<Customer> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            Console.WriteLine("Updated on DB.");
        }
    }
}
