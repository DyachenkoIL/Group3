/*Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее
арифметическое возвращаемых значений методов сообщенных с делегатами в массиве. Методы, сообщенные с
делегатами из массива, возвращают случайное значение типа int.
  Makhinko Vitalii
  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect7Task3
{
    class Program
    {
        delegate int Getnumber();

        delegate void Aver(Getnumber[] getnumbers);
        static void Main(string[] args)
        {
            int n = 10;
            Getnumber[] getnumbers = new Getnumber[n];
            for(int i =0; i<n;i++)
            {
                getnumbers[i] = Numb;
            }
            Aver aver = delegate(Getnumber[] getnumber)
            {
                double S = 0;
                foreach (Getnumber i in getnumber)
                    S += i();
                Console.WriteLine("|Average = {0}",S / getnumber.Length);
            };
            aver.Invoke(getnumbers);
            Console.ReadKey();

        }
        private static int Numb()
        {
            System.Threading.Thread.Sleep(15);
            Random rand = new Random();
            int a = rand.Next(1,10);
            Console.Write("{0} ",a);
            return a;
            
        }
    }
}