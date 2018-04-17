using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The number is not simple");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("The number is simple");
            Console.ReadKey();
        }
    }
}
