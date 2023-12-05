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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDao _employeeDao;
        public EmployeeManager(IEmployeeDao employeeDao)
        {
            _employeeDao = employeeDao;
        }

        public void Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
