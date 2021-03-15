using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ExportCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Your Export Credit has been calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
