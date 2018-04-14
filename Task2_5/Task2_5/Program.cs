using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number");
                
                s += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Average = " + s / 5);
            Console.ReadKey();
        }
    }
}
