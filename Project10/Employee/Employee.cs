using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Employee
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public int ContactPhone { get; set; }
        public string Adress { get; set; }
        public int OffDayMonthly { get; set; }
    }
}
