using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Customer : IEntity
    {
        public string CustomerId { get; set; } // in here, according to DB; ID is not a int, it is a string.
        public string CompanyName { get; set; }
        public string ContactName { get; set; } // null
    }
}
