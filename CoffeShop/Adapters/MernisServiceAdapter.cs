using CoffeShop.Abstracts;
using CoffeShop.Entities;
using CoffeShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Adapters
{
    internal class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationaltyId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
                customer.DateofBirth.Year) ;
        }
    }
}
