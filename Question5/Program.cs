using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Account
    {
        public void Balance()
        {
            Console.WriteLine("Base Class Balance");
        }
    }

    class Amount : Account
    {
        
        public void Balance()
        {
            Console.WriteLine("Derived Class Balance");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Amount amount = new Amount();

            account.Balance();
            amount.Balance();

            Console.ReadKey();
        }
    }
}
