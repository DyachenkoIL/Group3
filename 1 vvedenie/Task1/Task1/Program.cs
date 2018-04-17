using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                Console.WriteLine("1-st number is bigger, a = " + a);
            else
            if (b > a)
                Console.WriteLine("2-nd number is bigger, b = " + b);
            else
                Console.WriteLine("The same numbers are entered");
            Console.ReadKey();
        }
    }
}
