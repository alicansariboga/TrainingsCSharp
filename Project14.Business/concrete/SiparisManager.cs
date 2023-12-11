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
    public class SiparisManager : ISiparisService
    {
        ISiparisDao _siparisDao;
        public SiparisManager(ISiparisDao siparisDao)
        {
            _siparisDao = siparisDao;
        }

        public void Add(Siparis siparis)
        {
            _siparisDao.Add(siparis);
        }

        public void Delete(Siparis siparis)
        {
            _siparisDao.Delete(siparis);
        }

        public List<Siparis> GetAll()
        {
            return _siparisDao.GetAll();
        }

        public Siparis GetById(int id)
        {
            return _siparisDao.GetById(id);
        }

        public void Update(Siparis siparis)
        {
            _siparisDao.Update(siparis);
        }
    }
}
