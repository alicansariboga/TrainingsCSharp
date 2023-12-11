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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDao _employeeDao;
        public EmployeeManager(IEmployeeDao employeeDao)
        {
            _employeeDao = employeeDao;
        }

        public void Add(Employee employee)
        {
            _employeeDao.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDao.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDao.GetAll();
        }

        public Employee GetById(int id)
        {
            return _employeeDao.GetById(id);
        }

        public void Update(Employee employee)
        {
            _employeeDao.Update(employee);
        }
    }
}
