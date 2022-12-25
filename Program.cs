using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir class'ı kullanabilmek için onun bir örneğini oluşturmamız gereklidir. 
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager= new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "EBUBEKİR";
            customer.LastName = "DEMİR";
            customer.Id = 1;
            customer.City = "ORDU";

            Customer customer2 = new Customer
            {
                City = "GAZİANTEP",
                Id = 1,
                FirstName = "KAĞAN",
                LastName = "DOĞAN"
            };

            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }
    
   

}