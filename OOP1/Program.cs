using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 100;
            product.UnitInStock = 2;

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            productManager.Update(product);
            

            Console.ReadLine();

        }
    }
}
