using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class loopAssignment
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


            Console.WriteLine("program to print even numbers from 121 to 229 ");
            for ( i = 121; i <= 229; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("program to print odd numbers from 521 to 229 ");
            for (i = 521; i >= 229; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("program to show the use of break statement .");
            for (i = 2; i <= 20; i++)
            {
                if (i == 10)
                {
                    break;
                }

                Console.WriteLine(i);    
            }

            Console.WriteLine("program to find GCD and LCM of given number");


            Console.WriteLine("program to find GCD and LCM of given number");
            Console.WriteLine("Enter number1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2");
            int num2=Convert.ToInt32(Console.ReadLine());
            int x = num1;
            int y = num2;
            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else
                {
                    num2 = num2 - num1;
                }
            }
            int lcm = (x * y) / num1;
            Console.WriteLine("LCM :"+lcm);

            Console.WriteLine("GCD program");
            int u = 50;
            int v = 100;
            int gcd = 1;
            for (i = 1; i < (u + 1); i++)
            {
                if (u%i==0 && y % i == 0)
                {
                    gcd = i;
                }
                
            }
            Console.WriteLine(gcd);


            Console.WriteLine("program to print all alphabets from a to z using for loop");
            for (char ch = 'a'; i <= 'z'; ch++)
            {
                Console.WriteLine(ch);
            }






            Console.WriteLine(" program to find sum of all even numbers between 1 to n. ");
            Console.WriteLine(  "Enter number i.e.(n)");
            int n=Convert.ToInt32(Console.ReadLine());
            int add = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    add += i;

                }
                
            }
            Console.WriteLine(add);


            Console.WriteLine(" program to find sum of all odd numbers between 1 to n. ");
            Console.WriteLine("Enter number i.e.(m)");
            int m = Convert.ToInt32(Console.ReadLine());
            int add1 = 0;
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    add1 += i;

                }

            }
            Console.WriteLine(add1);

            Console.WriteLine("program to count number of digits in any number");
            Console.WriteLine("Enter Number");
            int h=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while(h>0)
            {
                h = h / 10;
                count++;
            }
            Console.WriteLine(count);


            Console.WriteLine("program to calculate product of digits of any number.");
            Console.WriteLine("Enter Number");
            int k = Convert.ToInt32(Console.ReadLine());
            int product = 1;

            while (k != 0)
            {

                product = product * (k % 10);
                k = k / 10;

            }
            Console.WriteLine(product);

            Console.WriteLine("program to find frequency of each digit in a given integer.");
            Console.WriteLine("Enter Number");
            int t=Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Prime Numbers between 400-300");
            for ( i = 400; i <= 300; i--)
            {
                 count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }

                }
                if (count == 0 && i != 1)
                {
                    Console.WriteLine(i);
                }


            }


            Console.WriteLine("table of given no");
            int rg=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{rg} x {i} = {rg*i}");
            }

            Console.WriteLine("Squares from 1-20");
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Square of {i} is {i*i}");
            }

            Console.Write("Enter any number: ");
            int basenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter any number: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            //caculatinh power of given number
            for (i = 1; i <= exponent; i++)
                power = power * basenumber;


            Console.Write("Power : " + power);


            Console.WriteLine("Factorial");
            Console.WriteLine("Enter NUmber");
            int ij = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for ( i = ij; i > 0; i--)
            {
                fact = fact * ij;
                ij--;
            }
            Console.WriteLine(fact);

            Console.WriteLine("P to check given no is Krishnamurthy or not");
            Console.WriteLine("Enter NUmber");
            int yh=Convert.ToInt32(Console.ReadLine());
            while (yh != 0)
            {
                int uh = yh % 10;

            }

            Console.WriteLine("Program to check palindrome");
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum1 = 0;
            while (n > 0)
            {
                int r = n % 10;
                sum1 = (sum1 * 10) + r;
                n = n / 10;
            }
            if (temp == sum1)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");

            Console.WriteLine("Automorphic number");
            Console.WriteLine("Enter Number");
            int op=Convert.ToInt32(Console.ReadLine());
            int squ = op * op;

            if (true) {
                while (op > 0)
                {
                    if (op % 10 != squ % 10) {
                        op = op / 10;
                        squ = squ / 10;
                    }
                }
                Console.WriteLine("Automorphic number");
            }
            else
            {

            }
            
            














        }
    }
}
