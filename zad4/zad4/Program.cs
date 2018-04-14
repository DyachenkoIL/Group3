using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит число 1 или 0 с помощью одной строки кода вывести на экран «Хорошо» если пользователь ввел 1 или «Плохо» если пользователь ввел 0");
            Console.WriteLine("Введите 1 или 0");
            string flag = (Console.ReadLine());
            Console.WriteLine(flag == "1" ? "Хорошо" : "Плохо");
            string fl = Console.ReadLine();
        }
    }
}
