using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class SiparisDetay : IEntity
    {
        public int SiparisId { get; set; } // foreign key
        public int ProductId { get; set; } // foreign key
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
    }
}
