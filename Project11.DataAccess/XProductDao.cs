using Project11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project11.DataAccess
{
    public class XProductDao : IProductDao
    {
        public List<Product> _products;
        public XProductDao()
        {
        _products = new List<Product>
        {
            new Product{ProductId=1, ProductName="Samsung MobilePhone", QuantityPerUnit="128 GB", UnitInStock=30, UnitPrice=15000},
            new Product{ProductId=1, ProductName="Apple MobilePhone", QuantityPerUnit="128 GB", UnitInStock=25, UnitPrice=18000},
            new Product{ProductId=1, ProductName="Huawei MobilePhone", QuantityPerUnit="128 GB", UnitInStock=45, UnitPrice=14000},
            new Product{ProductId=1, ProductName="Xiaomi MobilePhone", QuantityPerUnit="128 GB", UnitInStock=30, UnitPrice=12000},
            new Product{ProductId=1, ProductName="Realme MobilePhone", QuantityPerUnit="128 GB", UnitInStock=25, UnitPrice=10000},
            new Product{ProductId=1, ProductName="Oppo MobilePhone", QuantityPerUnit="128 GB", UnitInStock=50, UnitPrice=16000}
        };
    }

        public void Add(Product product)
        {
            Console.WriteLine("Product is added with X.");
        }

        public List<Product> GetAll()
        {
            return _products;
        }
    }
}
