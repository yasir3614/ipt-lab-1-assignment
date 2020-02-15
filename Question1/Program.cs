using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum number to find prime numbers till it:");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your input: {0}",numberInput);

            //Prime Logic
            int i = 0;
            bool isPrime = true;
            int j = 0;

            for (j = 0; j < numberInput; j++) {
                isPrime = true;
                for (i = 2; i <= numberInput / 2; ++i)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        
                    }
                }
                if (isPrime)
                    Console.WriteLine("Prime: {0}",j);
            
            }

            Console.ReadKey();
            

        }
    }
}
