using Project11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.DataAccess
{
    public interface IProductDao
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
