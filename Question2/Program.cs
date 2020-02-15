using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid string: ");
            String myString = Console.ReadLine();
            char[] copy = new char[myString.Length];

            if (myString.Length > 4)
            {
                String substring_one = myString.Substring(0, 4);

                for(int k = 0; k < 4; k++)
                {
                    copy[k] = substring_one[k];
                }

                String finalString = new String(copy);

                Console.WriteLine(finalString);

                for (int j = 4; j < myString.Length; j++)
                {
                    char c = char.ToUpper(myString[j]);
                    copy[j] = char.ToUpper(c);
                }

                finalString = new String(copy);
                Console.WriteLine("Final String: {0}" ,finalString);
            }
            else
            {
                Console.WriteLine("String must be atleast 5 letters long!");
            }

           
            Console.ReadKey();
            
       

            

        }
    }
}
