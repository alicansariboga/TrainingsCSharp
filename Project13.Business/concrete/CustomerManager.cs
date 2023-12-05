using Project13.Business.@abstract;
using Project13.Data.@abstract;
using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business.concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDao _customerDao;
        public CustomerManager(ICustomerDao customerDao)
        {
            _customerDao = customerDao;
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
