using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class starpatterns
    {
        static void Main(string[] args)
        {/*
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/

            /*int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/

            /*int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
*/

            /* int rows = 5;

             for (int i = rows; i >= 1; i--)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(j);
                 }
                 Console.WriteLine();
             }
             Console.ReadKey();*/


            int rows = 5;

            for (int i = rows; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();











        }
    }
}
