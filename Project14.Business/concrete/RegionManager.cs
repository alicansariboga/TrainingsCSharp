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
    public class RegionManager : IRegionService
    {
        IRegionDao _regionDao;
        public RegionManager(IRegionDao regionDao)
        {
            _regionDao = regionDao;
        }

        public void Add(Region region)
        {
            _regionDao.Add(region);
        }

        public void Delete(Region region)
        {
            _regionDao.Delete(region);
        }

        public List<Region> GetAll()
        {
            return _regionDao.GetAll();
        }

        public Region GetById(int id)
        {
            return _regionDao.GetById(id);
        }

        public void Update(Region region)
        {
            _regionDao.Update(region);
        }
    }
}
