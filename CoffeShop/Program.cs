using CoffeShop.Abstracts;
using CoffeShop.Adapters;
using CoffeShop.Concrete;
using CoffeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
     public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateofBirth=new DateTime(1998,06,11), FirstName="Kağan", LastName="Doğan", NationaltyId="37450951026" });


            Console.ReadLine();
        }
        
    }
}
