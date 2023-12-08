using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Entities
{
    public class Territory : IEntity
    {
        public int TerritoryId { get; set; }
        public int RegionId { get; set; } // foreign key
        public string TerritoryDecsription { get; set; }
    }
}
