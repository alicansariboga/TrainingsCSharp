using Project14.Business.@abstract;
using Project14.Data.@abstract;
using Project14.Data.concrete;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.concrete
{
    public class SiparisDetayManager : ISiparisDetayService
    {
        ISiparisDetayDao _siparisDetayDao;
        public SiparisDetayManager(ISiparisDetayDao siparisDetayDao)
        {
            _siparisDetayDao = siparisDetayDao;
        }

        public void Add(SiparisDetay siparisDetay)
        {
            _siparisDetayDao.Add(siparisDetay);
        }

        public void Delete(SiparisDetay siparisDetay)
        {
            _siparisDetayDao.Delete(siparisDetay);
        }

        public List<SiparisDetay> GetAll()
        {
            return _siparisDetayDao.GetAll();
        }

        public SiparisDetay GetById(int id)
        {
            return _siparisDetayDao.GetById(id);
        }

        public void Update(SiparisDetay siparisDetay)
        {
            _siparisDetayDao.Update(siparisDetay);
        }
    }
}
