using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class EmployeeDao : IEmployeeDao
    {
        public void Add(Employee employee)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Employees.Add(employee);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Employee employee)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Employees.Remove(logisticContext.Employees.SingleOrDefault(p => p.EmployeeId == employee.EmployeeId));
                logisticContext.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Employees.ToList();
            }
        }

        public Employee GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Employees.SingleOrDefault(p => p.EmployeeId == id);
            }
        }

        public void Update(Employee employee)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var employeeToUpdate = logisticContext.Employees.SingleOrDefault(p => p.EmployeeId == employee.EmployeeId);

                employeeToUpdate.FirstName = employee.FirstName;
                employeeToUpdate.LastName = employee.LastName;


                logisticContext.SaveChanges(); // save
            }
        }
    }
}
