using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Entity
{
    public class Customer : Person , IEntity
    {
        public string CustomerStatus { get; set; } // seller - purchaser - lodger
    }
}
