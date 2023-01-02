using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class demo5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of numbers from 1-20");
            int i, sum = 0;
            int avg = 0;
            for ( i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                sum += i;

            }
            avg = sum / 20;
            Console.WriteLine($"sum of numbers is{sum}");

            Console.WriteLine($"Average of numbers is{avg}");

        }
    }
}
