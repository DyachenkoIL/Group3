using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter number of month");
                month = Convert.ToInt32(Console.ReadLine());
            } while (month <= 0);
            if ((month < 3) || month == 12)
                Console.WriteLine("Winter");
            else if (month < 6)
                Console.WriteLine("Spring");
            else if (month < 9)
                Console.WriteLine("Summer");
            else if (month < 12)
                Console.WriteLine("Autumn");
            else Console.WriteLine("Earth doesn`t have this month");
            Console.ReadKey();
        }
    }
}
