using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Employee
{
    class EmployeeManager : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Employee information has been successfully added.");
        }

        public void Delete()
        {
            Console.WriteLine("Employee information has been successfully deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Employee information has been successfully updated.");
        }
    }
}
