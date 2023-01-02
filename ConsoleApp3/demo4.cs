using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class demo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 1 for addition");
            Console.WriteLine("Enter 2 for subtraction");

            Console.WriteLine("Enter 3 for multiplication");
            Console.WriteLine("Enter 4 for division");
            Console.WriteLine("Enter 5 for modulus");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double addition = num1 + num2;
                    Console.WriteLine(addition);
                break;
                case 2:
                    double subtraction = num1 - num2;
                    Console.WriteLine(subtraction);
                break;
                case 3:
                    double multiplication = num1 * num2;
                    Console.WriteLine(multiplication);
                break;
                case 4:
                    double division = num1 / num2;
                    Console.WriteLine(division);
                break;
                case 5:
                    double modulus = num1 % num2;
                    Console.WriteLine(modulus);
                    break;
            }







        }
    }
}
