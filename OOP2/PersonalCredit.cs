using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class PersonalCredit : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal credit calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
