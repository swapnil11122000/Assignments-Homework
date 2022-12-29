using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class demo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Physics Marks");
            double phy=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Chrmistry Marks");
            double chem=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks");
            double maths=Convert.ToDouble(Console.ReadLine());
            double total = chem + maths + phy;
            double percentage = ((chem + maths + phy) / 300 )*100;
            Console.WriteLine($"Total marks: {total} out of 300");
            Console.WriteLine($"Percentage :{percentage} Out of 100");
            if (percentage < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (percentage > 40 && percentage < 50)
            {
                Console.WriteLine("C Grade");
            }
            else if (percentage > 50 && percentage < 75)
            {
                Console.WriteLine("B Grade");
            }
            else if (percentage > 75)
            {
                Console.WriteLine("A Grade");

            }





        }
    }
}
