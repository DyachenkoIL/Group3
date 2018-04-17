using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20;i++)
            {
                Console.WriteLine(number + " * " + i + " = " + number * i);
            }
            Console.ReadKey();
        }
    }
}
