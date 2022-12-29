using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class demo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 || year % 400 == 0) Console.WriteLine("It is leap year");
            else Console.WriteLine("It is not leap year");


            Console.WriteLine("Enter number 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3) Console.WriteLine("Num1 is Greater than others");
            else if (num2 > num3) Console.WriteLine("Num2 is Greater than others");
            else  Console.WriteLine("Num3 is Greater than others");

           







        }
    }
}
