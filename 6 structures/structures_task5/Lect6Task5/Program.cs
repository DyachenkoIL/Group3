using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect6Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which message you want to write?");
            string stroka = Console.ReadLine();
            int color;
            
            do
            {
                Console.Write("What color do you prefer?\n0.Gray\n1.Green\n2.Red\n3.Blue\n4.White\n5.Yellow\nEnter number of color:");
                color = Convert.ToInt16(Console.ReadLine());
            } while ((color <= 0) || (color > 6));
            String.Print(stroka, color);
            Console.ReadKey();
        }
        public static class String
        {
            public static void Print (string stroka, int color)
            {
                Console.ForegroundColor= COLORS[(Color)color];
                Console.WriteLine(stroka);
            }
        }
        enum Color : int
        {
            Gray = 0,
            Green = 1,
            Red = 2,
            Blue = 3,
            White = 4,
            Yellow = 5
        };
        static Dictionary<Color, ConsoleColor> COLORS = new Dictionary<Color, ConsoleColor>()
        {

            {Color.Gray, ConsoleColor.Gray },
            {Color.Green, ConsoleColor.Green },
            {Color.Red, ConsoleColor.Red },
            {Color.Blue, ConsoleColor.Blue},
            {Color.White, ConsoleColor.White},
            {Color.Yellow, ConsoleColor.Yellow }
        };
    }
}
