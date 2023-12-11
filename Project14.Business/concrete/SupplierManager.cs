using Project14.Business.@abstract;
using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Business.concrete
{
    public class SupplierManager : ISupplierService
    {
        ISupplierDao _supplierDao;
        public SupplierManager(ISupplierDao supplierDao)
        {
            _supplierDao = supplierDao;
        }

        public void Add(Supplier supplier)
        {
            _supplierDao.Add(supplier);
        }

        public void Delete(Supplier supplier)
        {
            _supplierDao.Delete(supplier);
        }

        public List<Supplier> GetAll()
        {
            return _supplierDao.GetAll();
        }

        public Supplier GetById(int id)
        {
            return _supplierDao.GetById(id);
        }

        public void Update(Supplier supplier)
        {
            _supplierDao.Update(supplier);
        }
    }
}
