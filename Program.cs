using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите элемент массива N ");
           int n= Convert.ToInt32(Console.ReadLine());

            int[,] mass5 = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    mass5[i, j] = 1 - (i + j) % 2;
                    Console.Write(" "+mass5[i, j] + " ");
                   
                }
                             

                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
