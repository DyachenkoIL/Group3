using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect5Task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass;
            Console.Write("Сколько элементов будет в массиве?");
            int n = Convert.ToInt32(Console.ReadLine());
            mass = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rand = new Random();
                mass[i] = rand.Next(1, 100);
                Console.Write("{0} ", mass[i]);
                System.Threading.Thread.Sleep(15);
            }
            Console.WriteLine();
            bool napr = true;
            Console.Write("В каком направлении сортировать?(Ноль - в обратном порядке)");
            if (Convert.ToInt16(Console.ReadLine()) == 0)
                napr = false;
            mass = mass.Sourse(napr);
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", mass[i]);
            Console.ReadKey();
        }

    }
    public static class Massive
    {
        public static int[] Sourse(this int[] mass, bool napr)
        {
            QuickSort(mass, 0, mass.Length - 1);

            if (!napr)
            {
                int[] invmass = new int[mass.Length];
                for (int i = 0; i < mass.Length; i++)
                    invmass[i] = mass[mass.Length - i - 1];
                return invmass;
            }
            else
            {
                return mass;
            }
        }
        static void QuickSort(int[] mass, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = mass[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && mass[j] >= num)
                {
                    j--;
                }

                mass[i] = mass[j];

                while (i < j && mass[i] < num)
                {
                    i++;
                }

                mass[j] = mass[i];
            }

            mass[i] = num;
            QuickSort(mass, start, i - 1);
            QuickSort(mass, i + 1, end);
        }
    }
}
