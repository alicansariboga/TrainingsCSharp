using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.@abstract
{
    public interface ISupplierService
    {
        List<Supplier> GetAll();
        Supplier GetById(int id);
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(Supplier supplier);
    }
}
