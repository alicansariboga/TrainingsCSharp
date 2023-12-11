using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class RegionDao : IRegionDao
    {
        public void Add(Region region)
        {
            using(LogisticContext logisticContext = new LogisticContext()) 
            {
                logisticContext.Regions.Add(region);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Region region)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Regions.Remove(logisticContext.Regions.SingleOrDefault(p => p.RegionId == region.RegionId));
                logisticContext.SaveChanges();
            }
        }

        public List<Region> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Regions.ToList();
            }
        }

        public Region GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Regions.SingleOrDefault(p => p.RegionId == id);
            }
        }

        public void Update(Region region)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var regionToUpdate = logisticContext.Regions.SingleOrDefault(p => p.RegionId == region.RegionId);

                regionToUpdate.RegionDescription = region.RegionDescription;

                logisticContext.SaveChanges();
            }
        }
    }
}
