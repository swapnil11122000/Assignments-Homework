using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class forloop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1-10");
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Even Numbers from 1-50");
            for (int i=1;i<50;i++) 
            {
                 if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Odd Numbers from 1-50");
            for (int i = 1; i < 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Series from 100-50");
            for (int i = 100; i > 50; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Table");
            Console.WriteLine("Enter Number");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num}*{i}={i*num}");
            }


            
            
            

            








        }
    }
}
