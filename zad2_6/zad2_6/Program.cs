using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создать 5 случайных целых чисел, посчитать их среднее арифметическое и сообщить его пользователю");
            Random rand = new Random();
            int[] iarray = new int[5];
            double sum = 0;
            Console.Write("Список элементов: ");
            for (int i = 0; i < iarray.Length; i++)
            {
                iarray[i] = rand.Next(0,20);
                sum += iarray[i];
                Console.Write(" " + iarray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое чисел = " + (sum / 5));
            Console.ReadLine();
        }
    }
}
