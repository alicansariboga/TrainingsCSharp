using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Business.@abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> Get(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
