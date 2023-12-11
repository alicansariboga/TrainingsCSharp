using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface IShipperService
    {
        List<Shipper> GetAll();
        Shipper GetById(int id);
        void Add(Shipper shipper);
        void Update(Shipper shipper);
        void Delete(Shipper shipper);
    }
}
