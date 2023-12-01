using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13.Entity
{
    public class Car : IEntity
    {
        public int CarId { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarProductionYear { get; set; }
        public int CarSaleCost { get; set; }
        public int CarRentCost { get; set; }
    }
}
