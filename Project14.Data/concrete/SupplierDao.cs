using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class SupploerDao : ISupplierDao
    {
        public void Add(Supplier supplier)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Suppliers.Add(supplier);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Supplier supplier)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Suppliers.Remove(logisticContext.Suppliers.SingleOrDefault(p => p.SupplierId == supplier.SupplierId));
                logisticContext.SaveChanges();
            }
        }

        public List<Supplier> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Suppliers.ToList();
            }
        }

        public Supplier GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Suppliers.SingleOrDefault(p => p.SupplierId == id);
            }
        }

        public void Update(Supplier supplier)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var supplierToUpdate = logisticContext.Suppliers.SingleOrDefault(p => p.SupplierId == supplier.SupplierId);

                supplierToUpdate.CompanyName = supplierToUpdate.CompanyName;
                supplierToUpdate.ContactName = supplierToUpdate.ContactName;

                logisticContext.SaveChanges();
            }
        }
    }
}
