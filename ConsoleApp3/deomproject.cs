using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class deomproject
    {
        static void Main(string[] args)
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
            //Console.WriteLine("Enter NUmber");
            //int num=Convert.ToInt32(Console.ReadLine());
            //if (num > 0)
            //{
            //    Console.WriteLine("It is positive");

            // }
            // else if (num == 0)
            // {
            //     Console.WriteLine("It is zero");

            //}
            //else
            //{
            //   Console.WriteLine("it is negatiove");
            // }
            int a = 10;
            int b = ++a + a-- - a++;
            int c = --b - ++a + b--;
            int d = ++a + --b + c++;
            Console.WriteLine($"a={a}");//9
            Console.WriteLine($"b={b}");//22
            Console.WriteLine($"c={c}");//190
            Console.WriteLine($"d={d}");//3989

        }
    }
}
