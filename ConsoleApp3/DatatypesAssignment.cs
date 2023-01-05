using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class DatatypesAssignment
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program to check leap year or not");
            Console.WriteLine("Enter year");
            int year=Convert.ToInt32(Console.ReadLine());
            if (year%4==0 || year % 400 == 0)
            {
                Console.WriteLine("It is leap year");
            }
            else
            {
                Console.WriteLine("it is not leap year");
            }

            Console.WriteLine("program to check whether a number is divisible by 5 and 11 or not ");
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num / 5 == 0  && num / 11 == 0 )
            {
                Console.WriteLine("number is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("number is not divisible by 5 and 11");
            }

            Console.WriteLine("program to find maximum between three numbers ");
            Console.WriteLine("Enter number 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is greater");
            }
            else if (num2 > num3) 
            {
                Console.WriteLine("num2 is greater");
            }
            else
            {
                Console.WriteLine("num3 is greater");
            }


            Console.WriteLine("program to input any alphabet and check whether it is vowel or consonant ");
            Console.WriteLine("Enter Alphabet");
            string s=Console.ReadLine();
            if (s=="a" || s=="e" || s=="i" || s=="o" || s=="u" || s == "A" || s == "E" || s == "I" || s == "O" || s == "U")
            {
                Console.WriteLine("Alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("It is Consonent");
            }

            Console.WriteLine("program to create Simple Calculator ");
            Console.WriteLine(  "Enter number1");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NUmber2");
            int number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            Console.WriteLine("Enter 5 for Modulus");
            int func=Convert.ToInt32(Console.ReadLine());
            switch(func)
            {
                case 1:
                    int add=number1+ number2;
                    Console.WriteLine(add);
                    break;
                case 2:
                    int mod = number1 % number2;
                    Console.WriteLine(mod);
                    break;
                case 3:
                    int sub = number1 - number2;
                    Console.WriteLine(sub);
                    break;
                case 4:
                    int mul = number1 * number2;
                    Console.WriteLine(mul);
                    break;
                case 5:
                    int div = number1 / number2;
                    Console.WriteLine(div);
                    break;
                default:
                    Console.WriteLine("wrong Input");
                    break;

            }

            Console.WriteLine(" program to check whether a number is negative, positive or zero ");
            Console.WriteLine("Enter NUmber");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 0) Console.WriteLine("It is zero");
            else if (n > 0) Console.WriteLine("Number is positive");
            else Console.WriteLine("It is Negative");

            Console.WriteLine("program to input any character and check whether it is alphabet, digit or special character");
            Console.WriteLine("Enter Character");
            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'z')
            {
                Console.WriteLine("It is alphabet");
            }
            else if (c >= 0 && c <= 9)
            {
                Console.WriteLine("it is number");
            }
            else Console.WriteLine("It is special character");


            Console.WriteLine("program to check whether a number is even or odd  ");
            Console.WriteLine("Enter NUmber");
            int NUM=Convert.ToInt32(Console.ReadLine());
            if (NUM % 2 == 0)
            {
                Console.WriteLine("It is even");

            }
            else if (NUM == 0)
            {
                Console.WriteLine("It is zero");

            }
            else
            {
                Console.WriteLine("It is odd");
            }

            Console.WriteLine("program to accept the amount from the user and display the break-up in descending order of denominations. ");
            Console.WriteLine("Enter amount");
            int a=Convert.ToInt32(Console.ReadLine());
            if (a > 99999)
            {
                Console.WriteLine("Invalid Amount");
            }

            Console.WriteLine("program to input basic salary of an employee and calculate its Gross salary ");
            Console.WriteLine("Enter salary amount");
            int sal=Convert.ToInt32(Console.ReadLine());
            if (sal <= 10000)
            {
                int da = (sal / 100) * 80;
                int hra = (sal / 100) * 20;
                int total = sal + da + hra;
                Console.WriteLine(total);

            }
            else if (sal <= 20000)
            {
                int da = (sal / 100) * 90;
                int hra = (sal / 100) * 25;
                int total = sal + da + hra;
                Console.WriteLine(total);
            }
            else if (sal > 20000)
            {
                int da = (sal / 100) * 95;
                int hra = (sal / 100) * 30;
                int total = sal + da + hra;
                Console.WriteLine(total);
            }

            Console.WriteLine(" program to check whether entered number is 3 digit or not .If it is a 3 digit no. then do sum of 1st and 3rd digit");
            Console.WriteLine("Enter number");
            uint d=Convert.ToUInt32(Console.ReadLine());
            if (d>=100 && d <= 999)
            {
                Console.WriteLine("It is three digit number");
                uint third = d / 100;
                uint first = d % 10;
                uint sum=third+ first;
                Console.WriteLine("sum of first and third digit :"+sum);
            }
            else
            {
                Console.WriteLine("It is not three digit number");
            }

            Console.WriteLine("program that displays the day of the week ");
            Console.WriteLine("Enter Number to display corresponding day of week");
            int w=Convert.ToInt32(Console.ReadLine());
            switch (w)
            {
                case 1: Console.WriteLine("Monday");
                    break;
                case 2: Console.WriteLine("Tuesday");
                    break;
                case 3: Console.WriteLine("Wednesday");
                    break;
                case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;
                default: Console.WriteLine("day does not exist");
                    break;
            }


            Console.WriteLine("program to enter number between 1to 5 and print it in word");
            Console.WriteLine("Enter Number to display in words");
            int f = Convert.ToInt32(Console.ReadLine());
            switch (f)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three"   );
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                
                default:
                    Console.WriteLine("wrong input");
                    break;
            }



            Console.WriteLine("Areas and circumferences and perimeters");
            Console.WriteLine("Enter 1 for Area of circle");
            Console.WriteLine("Enter 2 for Area of square");
            Console.WriteLine("Enter 3 for Area of right angled triangle");
            Console.WriteLine("Enter 4 for Area of rectangle");
            Console.WriteLine("Enter 5 for Circumference of circle");
            Console.WriteLine("Enter 6 for perimeter of square");
            int h= Convert.ToInt32(Console.ReadLine());
            switch (h)
            {
                case 1:
                    {
                        Console.WriteLine("Enter radius");
                        double ac=Convert.ToDouble(Console.ReadLine());
                        double areaofcircle = ac * 3.14;
                        Console.WriteLine("Area of circle"+areaofcircle);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter side");
                        double fe=Convert.ToDouble(Console.ReadLine());
                        double areaofsquare = fe * fe;
                        Console.WriteLine("Area of Dquare" + areaofsquare);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter side1");
                        double gr=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter side2");
                        double xs=Convert.ToDouble(Console.ReadLine());
                        double wd = (gr * xs) / 2;
                        Console.WriteLine("Area of right angled triangle"+wd);
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Enter side1");
                        double ef=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter side2");
                        double rg=Convert.ToDouble(Console.ReadLine());
                        double mk = ef * rg;
                        Console.WriteLine("Area of rectangle" + mk);
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Enter radius");
                        double mn=Convert.ToDouble(Console.ReadLine());
                        double vf = 2 * 3.14 * mn;
                        Console.WriteLine("Circumference of circle" + vf);
                        break;  
                    }
                    case 6:
                    {
                        Console.WriteLine("Enter side");
                        double ij=Convert.ToDouble(Console.ReadLine());
                        double nk=4* ij;
                        Console.WriteLine("Perimenter of Square" + nk);
                        break;
                    }

            }
























        }
    }
}
