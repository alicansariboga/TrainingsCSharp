using Project14.Business.@abstract;
using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.concrete
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
            _customerDao.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDao?.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDao.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDao.GetById(id);
        }

        public void Update(Customer customer)
        {
            _customerDao.Update(customer);
        }
    }
}
