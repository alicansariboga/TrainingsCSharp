using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface ISiparisDetayService
    {
        List<SiparisDetay> GetAll();
        SiparisDetay GetById(int id);
        void Add(SiparisDetay siparisDetay);
        void Update(SiparisDetay siparisDetay);
        void Delete(SiparisDetay siparisDetay);
    }
}
