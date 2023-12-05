using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business.@abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetById(int Id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
