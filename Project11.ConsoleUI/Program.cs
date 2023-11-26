// See https://aka.ms/new-console-template for more information

//MAIN
using Project11.Business;
using Project11.DataAccess;

ProductManager productManager = new ProductManager(new XProductDao()); // or "(new ProductDao())"

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
    Console.WriteLine(product.QuantityPerUnit);
    Console.WriteLine(product.UnitPrice);
}

