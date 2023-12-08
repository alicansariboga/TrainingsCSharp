using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; } // foreign key
        public int CategoryId { get; set; } // foreign key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; } //not int. smallInt=short
    }
}
