/*
 Создайте анонимный метод, который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
 Dyachenko Igor
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegats_task1
{
    public delegate double Middle(int a, int b, int c);

    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            string next = "y";
            while (next == "y")
            {
                Console.WriteLine("Введите 3 целочисленных аргумента: ");
                while (!int.TryParse(Console.ReadLine(), out a1)) Console.WriteLine("Введите ЦЕЛОЧИСЛЕННОЕ значение!!!");
                while (!int.TryParse(Console.ReadLine(), out a2)) Console.WriteLine("Введите ЦЕЛОЧИСЛЕННОЕ значение!!!");
                while (!int.TryParse(Console.ReadLine(), out a3)) Console.WriteLine("Введите ЦЕЛОЧИСЛЕННОЕ значение!!!");
                Middle main = (x, y, z) => { return Convert.ToDouble(x + y + z) / 3; };
                Console.WriteLine("Среднее арифметическое чисел {0}, {1}, {2} = {3}", a1, a2, a3, main(a1, a2, a3));
                Console.WriteLine("Продолжить? (y если да)");
                next = Console.ReadLine();
                if (next == "y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Программа завершает свою работу");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
