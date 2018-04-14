using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит число вывесли на экран количество разрядов в этом числе");
            Console.WriteLine("Введите число: ");
            ulong per = Convert.ToUInt64(Console.ReadLine());
            int rasrjad = 0;
            while (per != 0)
            {
                per /= 10;
                rasrjad++;
            }
            Console.WriteLine("Количество разрядов в числе = {0}.", rasrjad);
            Console.ReadLine();
        }
    }
}
