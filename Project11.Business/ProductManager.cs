using Project11.DataAccess;
using Project11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.Business
{
    public class ProductManager
    {
        IProductDao _productDao;
        public ProductManager(IProductDao productDao)
        {
            _productDao = productDao;
        }
        public List<Product> GetAll()
        {
            return _productDao.GetAll();
        }
    }
}
