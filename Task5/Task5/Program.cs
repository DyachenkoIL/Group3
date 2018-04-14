using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            do
            {
                Console.Clear();
                Console.WriteLine("Select day of week (from 1 to 7): ");
                day = Convert.ToInt32(Console.ReadLine());
            } while ((day <= 0) || (day > 7));
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thusday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
            }
            Console.ReadKey();
        }
    }
}
