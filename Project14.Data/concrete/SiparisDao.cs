using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class SiparisDao : ISiparisDao
    {
        public void Add(Siparis siparis)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Siparisler.Add(siparis);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Siparis siparis)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Siparisler.Remove(logisticContext.Siparisler.SingleOrDefault(p => p.SiparisId == siparis.SiparisId));
                logisticContext.SaveChanges();
            }
        }

        public List<Siparis> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Siparisler.ToList();
            }
        }

        public Siparis GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Siparisler.SingleOrDefault(p => p.SiparisId == id);
            }
        }

        public void Update(Siparis siparis)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var siparisToUpdate = logisticContext.Siparisler.SingleOrDefault(p => p.SiparisId == siparis.SiparisId);

                siparisToUpdate.CustomerId = siparis.CustomerId;
                siparisToUpdate.EmployeeId = siparis.EmployeeId;

                logisticContext.SaveChanges();
            }
        }
    }
}
