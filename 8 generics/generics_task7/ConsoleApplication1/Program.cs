/*
Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections. 

Дяченко Игорь
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyArrayList
    {
        private static int n;
        private int[] arr = new int[n];

        private static int current;

        public void Count() //Для показа работоспособности вывод размера в зависимости от к-ва эл-тов
        {
            Console.WriteLine("Размер массива: {0}\nНомер добавляемого эл-та: {1}", arr.Length, current);
        }

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        public MyArrayList()
        {
            n = 1;
        }

        public MyArrayList(int cap)
        {
            n = cap;
        }

        public void Add(int someval)
        {
            if (current < arr.Length)
            {
                arr[current] = someval;
                current++;
            }
            else
            {
                if (current != 0)//Для избежания удвоения введёного вручную размера при первом добавлении эл-та
                {
                    n *= 2; //Увеличение размера массива в 2 раза
                    Array.Resize<int>(ref arr, n);
                    arr[current] = someval;
                    current++;
                }
                else
                {
                    Array.Resize<int>(ref arr, n);
                    arr[current] = someval;
                    current++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList(5);

            for (int i = 0; i < 30; i++)
            {
                list.Add(i);
                list.Count();
                Console.WriteLine("--------");
            }

            Console.ReadKey();
        }
    }
}
