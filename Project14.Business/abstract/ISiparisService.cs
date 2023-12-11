using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface ISiparisService
    {
        List<Siparis> GetAll();
        Siparis GetById(int id);
        void Add(Siparis siparis);
        void Update(Siparis siparis);
        void Delete(Siparis siparis);
    }
}
