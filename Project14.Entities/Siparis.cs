using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Siparis : IEntity
    {
        public int SiparisId { get; set; }
        public int CustomerId { get; set; } // foreign key
        public int EmployeeId { get; set; } // foreign key
        //public int ShipVia { get; set; } // foreign key
        //public DateTime SiparisTarihi { get; set; }
    }
}
