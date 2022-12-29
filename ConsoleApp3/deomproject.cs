using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class deomproject
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Enter Number");
            //int num=Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("It is Even Number");

            //}
            // else
            // {
            //    Console.WriteLine("IT is Odd Number");
            // }
            Console.WriteLine("Enter NUmber");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("It is positive");

            }
            else if (num == 0)
            {
                Console.WriteLine("It is zero");

            }
            else
            {
                Console.WriteLine("it is negatiove");
            }

        }
    }
}
