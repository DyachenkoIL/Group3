using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Служба такси заказала вам программу, которая спрашивает количество километров и количество минут простоя, а дальше считает так: первые 5 километров (или до 5 км) 20 гривен, каждый следующий километр 3 гривны, плюс простой 1 грн за 1 минуту. Программа должна посчитать и сказать общую сумму оплаты за поездку.");
            Console.WriteLine("Количество километров: ");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество минут простоя: ");
            int mp = Convert.ToInt32(Console.ReadLine());
            int sum;
            if (km <= 5) sum = 20 + mp;
            else sum = 20 + (km-5)*3 + mp;
            Console.WriteLine("Общая сумма оплаты за поездку {0} грн", sum);
            Console.ReadLine();
        }
    }
}
