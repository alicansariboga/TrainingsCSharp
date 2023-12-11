using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class TerritoryDao : ITerritoryDao
    {
        public void Add(Territory territory)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Territories.Add(territory);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Territory territory)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Territories.Remove(logisticContext.Territories.SingleOrDefault(p => p.TerritoryId == territory.TerritoryId));
                logisticContext.SaveChanges();
            }
        }

        public List<Territory> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Territories.ToList();
            }
        }

        public Territory GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Territories.SingleOrDefault(p => p.TerritoryId == id);
            }
        }

        public void Update(Territory territory)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var territoryToUpdate = logisticContext.Territories.SingleOrDefault(p => p.TerritoryId == territory.TerritoryId);
                territoryToUpdate.RegionId = territory.RegionId;
                territoryToUpdate.TerritoryDecsription = territory.TerritoryDecsription;

                logisticContext.SaveChanges();
            }
        }
    }
}
