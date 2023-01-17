using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class dowhileloop
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Program to print numbers from 1-10");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);*/


            /*Console.WriteLine("P to print even numbers from 1.- 50");
            int i = 2;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 50);
*/
            /*Console.WriteLine("P to print odd numbers from 1.- 50");
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i += 2;
            } while (i <= 50);

            
*/

            /*Console.WriteLine("deries from 100-50");
            int i = 100;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i >= 50);*/

            /*
                        Console.WriteLine("Table");
                        Console.WriteLine("Enter number");
                        int i=Convert.ToInt32(Console.ReadLine());
                        int j = 1;
                        do
                        {
                            Console.WriteLine($"{i} x {j} = {i * j}");
                            j++;
                        } while (j <= 10);*/



            /*Console.WriteLine("number from 1 to 10 & is sum");
            int i = 1;
            int total = 0;

            do
            {
                Console.WriteLine(i);
                total += i;
                i++;
            } while (i <= 10);

            Console.WriteLine("Total: " + total);*/




            /*Console.WriteLine("while loop");
            Console.WriteLine("P to accept a 3 digit number from user & print in reverse order using while loop");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i > 1)
            {
                int j = i % 10;
                int k = i / 10;
                int l = k % 10;
                int o = k / 10;
                Console.WriteLine($"{j}{l}{o}");
               
                break;

            }*/

            /* Console.WriteLine("while loop");
             Console.WriteLine("Accept a 3 digit number from user & check number is armstrong number or not");
             Console.WriteLine("Enter number");
             int i = Convert.ToInt32(Console.ReadLine());
             int sum = 0;
             while (i > 1)
             {
                 int j = i % 10;
                 int k = i / 10;
                 int l = k % 10;
                 int o = k / 10;
                 sum = (j * j * j) + (l * l * l) + (o * o * o);
                 Console.WriteLine(sum);
                 if (sum == i)
                 {
                     Console.WriteLine("it is armastrong number");
                 }
                 else
                 {
                     Console.WriteLine("it is not armastrong number");
                 }


                 break;

             }*/


            int num;
            while (true)
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());

                if (num < 2)
                {
                    Console.WriteLine("Number must be greater than 1.");
                    continue;
                }

                bool isPrime = true;
                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(num + " is a prime number.");
                }
                else
                {
                    Console.WriteLine(num + " is not a prime number.");
                }
            }











        }
    }
}
