using System;

namespace OOP1FrknGlc
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 68;
            product1.ProductName = "Acer";
            product1.CategoryId = 2;
            product1.UnitPrice = 5400;
            product1.UnitsInStock = 5;


            Product product2 = new Product { Id=5,CategoryId=8,UnitsInStock=7,
                ProductName="MSİ",UnitPrice=6000};


            //PascalCase     //CamelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            Console.WriteLine(productManager.Topla(3, 5) * 2);
        }
    }
}
