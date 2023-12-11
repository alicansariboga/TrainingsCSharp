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
    public class ShipperManager : IShipperService
    {
        IShipperDao _shipperDao;
        public ShipperManager(IShipperDao shipperDao)
        {
            _shipperDao = shipperDao;
        }

        public void Add(Shipper shipper)
        {
            _shipperDao.Add(shipper);
        }

        public void Delete(Shipper shipper)
        {
            _shipperDao.Delete(shipper);
        }

        public List<Shipper> GetAll()
        {
            return _shipperDao.GetAll();
        }

        public Shipper GetById(int id)
        {
            return _shipperDao.GetById(id);
        }

        public void Update(Shipper shipper)
        {
            _shipperDao.Update(shipper);
        }
    }
}
