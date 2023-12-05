using Project13.Data.@abstract;
using Project13.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Data.concrete
{
    public class EmployeeDao : IEmployeeDao
    {
        public List<Employee> _employees;
        public EmployeeDao()
        {
            _employees = new List<Employee>()
            {
                new Employee { Id = 1, NationalIdentity = 14314135311, FirstName = "Test", LastName = "Employee-1", City = "Adana", Salary=11000, ContactPhone=90050010101,Adress="test adress employee - 1", OffDayMonthly=4 },
                new Employee { Id = 2, NationalIdentity = 14314465311, FirstName = "Test", LastName = "Employee-2", City = "Adana", Salary=12000, ContactPhone=90050010101,Adress="test adress employee-2", OffDayMonthly=4 }
            };
        }

        public void Add(Employee entity)
        {
            Console.WriteLine("Added to DB.");
        }

        public void Delete(Employee entity)
        {
            Console.WriteLine("Deleted from DB.");
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public List<Employee> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            Console.WriteLine("Updated on DB.");
        }
    }
}
