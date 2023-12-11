using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface IRegionService
    {
        List<Region> GetAll();
        Region GetById(int id);
        void Add(Region region);
        void Update(Region region);
        void Delete(Region region);
    }
}
