using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class BankPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Making bank payment...");
        }
    }
}
