using Project14.Business.@abstract;
using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.concrete
{
    public class TerritoryManager : ITerritoryService
    {
        ITerritoryDao _territoryDao;
        public TerritoryManager(ITerritoryDao territoryDao)
        {
            _territoryDao = territoryDao;
        }

        public void Add(Territory territory)
        {
            _territoryDao.Add(territory);
        }

        public void Delete(Territory territory)
        {
            _territoryDao.Delete(territory);
        }

        public List<Territory> GetAll()
        {
            return _territoryDao.GetAll();
        }

        public Territory GetById(int id)
        {
            return _territoryDao.GetById(id);
        }

        public void Update(Territory territory)
        {
            _territoryDao.Update(territory);
        }
    }
}
