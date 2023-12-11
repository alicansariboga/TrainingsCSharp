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
    public class ProductManager : IProductService
    {
        IProductDao _productDao;
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }

        public void Add(Product product)
        {
            _productDao.Add(product);
        }

        public void Delete(Product product)
        {
            _productDao.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDao.GetAll();
        }

        public Product GetById(int id)
        {
            return _productDao.GetById(id);
        }

        public void Update(Product product)
        {
            _productDao.Update(product);
        }
    }
}
