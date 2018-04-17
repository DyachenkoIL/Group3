using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите программу, которая будет «спрашивать» правильный пароль, до тех пор, пока он не будет введен. Правильный пароль пусть будет «root». Если пароль не верный, программа должна сказать 'Неверный пароль!'");
            string rightpass = "root";
            Console.WriteLine("Введите пароль");
            string userpass = Console.ReadLine();
            while (userpass!=rightpass)
            {
                Console.WriteLine("Неверный пароль");
                Console.WriteLine("Введите пароль снова");
                userpass = Console.ReadLine();
            }
            Console.WriteLine("Пароль введён верно");
            Console.ReadLine();
        }
    }
}
