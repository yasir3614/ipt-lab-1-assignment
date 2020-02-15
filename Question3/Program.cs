using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Size Of Matrix: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size,size];

            Random random = new Random();
           



            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    int num = random.Next() % 100;
                    matrix[i,j] = num;

                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    Console.Write(matrix[i, j].ToString() + " ");
                    
                }
                Console.WriteLine();
            }


            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (i == j)
                    {
                        sum = matrix[i, j] + sum;
                    }
                    

                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();
        }
    }
}
