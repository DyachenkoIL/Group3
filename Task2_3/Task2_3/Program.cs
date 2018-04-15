
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, user;
            Random rand = new Random();
            number = (rand.Next() % 146)+1;
            Console.WriteLine("Try to guess number");
            user = Convert.ToInt32(Console.ReadLine());
            while (user != number)
            {
                Console.WriteLine("You did not guess the number. Try again");
                if (number > user)
                    Console.WriteLine("Number, which you find is greater");
                else Console.WriteLine("Number, which you find is smaller");
                user = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Congratulations!!! You guessed the number!!!");
            Console.ReadKey();
        }
    }
}
