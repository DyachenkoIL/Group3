using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выведите все точные квадраты натуральных чисел, которые (квадраты)меньше заданного числа N. (натуральные - это числа, которые мы используем при счёте: 1, 2, 3 и т.д.)");
            Console.WriteLine("Какое число не должны превышать квадраты натуральных чисел?");
            int max = Convert.ToInt32(Console.ReadLine());
            int schet = 1;
            while ((Math.Pow(schet, 2)) < max)
            {
                Console.WriteLine(Math.Pow(schet,2));
                schet++;
            }
            Console.ReadLine();
        }
    }
}
