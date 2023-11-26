using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Customer
{
    class CustomerManager : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Customer information has been successfully added.");
        }

        public void Delete()
        {
            Console.WriteLine("Customer information has been successfully deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Customer information has been successfully updated.");
        }
    }
}
