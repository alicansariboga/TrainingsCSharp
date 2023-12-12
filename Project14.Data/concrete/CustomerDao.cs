using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class CustomerDao : ICustomerDao
    {
        public void Add(Customer customer)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Customers.Add(customer);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Customer customer)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Customers.Remove(logisticContext.Customers.SingleOrDefault(p => p.CustomerId == customer.CustomerId));
                logisticContext.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Customers.ToList();
            }
        }

        // there is a convert erro for int.
        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetById(string id)
        {
            using(LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Customers.SingleOrDefault(p => p.ContactName == id);
            }
        }

        public void Update(Customer customer)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var customerToUpdate = logisticContext.Customers.SingleOrDefault(p => p.CustomerId == customer.CustomerId);

                customerToUpdate.CompanyName = customer.CompanyName;
                customerToUpdate.ContactName = customer.ContactName;

                logisticContext.SaveChanges();
            }
        }
    }
}
