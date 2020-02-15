using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Calculator
    {

        public double Sum(int a,int b)
        {
            return a + b;
        }

        public double Subtract(int a, int b)
        {
            return a - b;
        }

        public double Divide(int a, int b)
        {
            return a/b;
        }

        public double Multiply(int a, int b)
        {
            return a * b;
        }


        public double Sum(params double[] numbers)
        {
            double result = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                result = result + numbers[i];
            }
            return result;
        }

        public double Subtract(params double[] numbers)
        {
            double result = numbers[0];
            
            for (int i = 1; i < numbers.Length; i++)
            {
                result =  result - numbers[i];
                //Console.WriteLine("result: "  + result);
            }
            return result;
        }

        public double Divide(params double[] numbers)
        {
            double result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result = result / numbers[i];
            }
            return result;
        }

        public double Multiply(params double[] numbers)
        {
            double result = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                result = numbers[i] * result;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            
            Console.WriteLine("Sum of 1,2,3,4: \n" + calc.Sum(1, 2, 3, 4));
            Console.WriteLine("\nSubtraction of 10,5,4: \n" + calc.Subtract(10, 5,4 ));
            Console.WriteLine("\nMultiplication of 4,2,3: \n"  + calc.Multiply(4, 2, 3));
            Console.WriteLine("\nDivision of 80,2,4: \n" + calc.Divide(80, 2, 4));

            Console.ReadKey();

        }
    }
}
