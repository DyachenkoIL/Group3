using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("64 paws can have ...");
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine(32 - 2 * i + " goose and " + i + " rabbits");
            }
            Console.ReadKey();
        }
    }
}
