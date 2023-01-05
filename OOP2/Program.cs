using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCredit = new PersonalCredit();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.ToApply(personalCredit);

            List<ICreditManager> credits = new List<ICreditManager>() {personalCredit, vehicleCreditManager };
            applicationManager.CreditInformation(credits);
            Console.ReadLine();
        }
    }
}
