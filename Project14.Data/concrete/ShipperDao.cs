using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class ShipperDao : IShipperDao
    {
        public void Add(Shipper shipper)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Shippers.Add(shipper);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Shipper shipper)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Shippers.Remove(logisticContext.Shippers.SingleOrDefault(p => p.ShipperId == shipper.ShipperId));
                logisticContext.SaveChanges();
            }
        }

        public List<Shipper> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Shippers.ToList();
            }
        }

        public Shipper GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Shippers.SingleOrDefault(p => p.ShipperId == id);
            }
        }

        public void Update(Shipper shipper)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var shipperToUpdate = logisticContext.Shippers.SingleOrDefault(p => p.ShipperId == shipper.ShipperId);

                shipperToUpdate.CompanyName = shipper.CompanyName;
                shipperToUpdate.Phone = shipper.Phone;

                logisticContext.SaveChanges();
            }
        }
    }
}
