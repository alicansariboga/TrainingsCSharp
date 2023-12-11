using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class SiparisDetayDao : ISiparisDetayDao
    {
        public void Add(SiparisDetay siparisDetay)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.SiparisDetaylar.Add(siparisDetay);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(SiparisDetay siparisDetay)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.SiparisDetaylar.Remove(logisticContext.SiparisDetaylar.SingleOrDefault(p => p.SiparisId == siparisDetay.SiparisId));
            logisticContext.SaveChanges() ;
            }
        }

        public List<SiparisDetay> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.SiparisDetaylar.ToList();
            }
        }

        public SiparisDetay GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.SiparisDetaylar.SingleOrDefault(p => p.SiparisId == id);
            }
        }

        public void Update(SiparisDetay siparisDetay)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var siparisDetayToUpdate = logisticContext.SiparisDetaylar.SingleOrDefault(p => p.SiparisId == siparisDetay.SiparisId);

                siparisDetayToUpdate.ProductId = siparisDetay.ProductId;
                // product id maybe should not updated. Instead of updating, can create a new order. It does not matter right now bc, it is a test. However, Normally, this varies depending on project needs.

                siparisDetayToUpdate.UnitPrice = siparisDetay.UnitPrice;
                siparisDetayToUpdate.Quantity = siparisDetay.Quantity;
                siparisDetayToUpdate.Discount = siparisDetay.Discount;

                logisticContext.SaveChanges() ;
            }
        }
    }
}
