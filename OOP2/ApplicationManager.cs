using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class ApplicationManager
    {
        public void ToApply (ICreditManager creditManager)
        {
            creditManager.Calculate();
        }
        public void CreditInformation(List <ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
