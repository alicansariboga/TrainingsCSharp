using Project14.Data.@abstract;
using Project14.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Project14.Data.concrete
{
    public class ProductDao : IProductDao
    {
        public void Add(Product product)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                logisticContext.Products.Add(product);
                logisticContext.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                // logisticContext.Products.Remove(product);
                logisticContext.Products.Remove(logisticContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId));
                logisticContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Products.ToList();
            }
        }

        public Product GetById(int id)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                return logisticContext.Products.SingleOrDefault(p => p.ProductId == id);
            }
        }

        public void Update(Product product)
        {
            using (LogisticContext logisticContext = new LogisticContext())
            {
                var productToUpdate = logisticContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId); // not updted data

                // update area
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.QuantityPerUnit= product.QuantityPerUnit;
                productToUpdate.UnitPrice= product.UnitPrice;
                productToUpdate.UnitsInStock= product.UnitsInStock;
                productToUpdate.CategoryId= product.CategoryId;
                productToUpdate.SupplierId= product.SupplierId;

                logisticContext.SaveChanges(); // saved changes.
            }
        }
    }
}
