using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        public static bool CompareObjects(object obj1,object obj2)
        {

            //returns false because it compares the reference rather than the string values
            return obj1 == obj2;

        }

        static void Main(string[] args)
        {
            string string1 = new string(new char[]{'h', 'e', 'l', 'l', 'o'});
            string string2 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });


            bool checkOnCompareObjects = CompareObjects(string1, string2);

            int compareToCheckBuiltIn = string1.CompareTo(string2);

            Console.WriteLine("Compare Objects returns "+checkOnCompareObjects);

            if (compareToCheckBuiltIn == 0)
            {
                Console.WriteLine("CompareTo Returns True");
            } else
            {
                Console.WriteLine("CompareTo Returns False");
            }


            Console.WriteLine("\nConclusion: Not same, because it compares the reference rather than the string values");
            Console.ReadKey();
        }
    }
}
