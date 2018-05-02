/*
Создайте класс MyList<T>. Реализуйте в простейшем приближении возможность использования его
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс взаимодействия с
экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по
указанному индексу и свойство только для чтения для получения общего количества элементов.

Создайте расширяющий метод: public static T[] GetArray<T>(this MyList<T> list)
Примените расширяющий метод к экземпляру типа MyList<T>, разработанному в домашнем задании 2 для
данного урока. Выведите на экран значения элементов массива, который вернул расширяющий метод
GetArray().

Makhinko Vitalii
*/

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect8Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            MyList<int> List1 = new MyList<int>();
            for(int i = 0;i<4;i++)
            {
                Console.WriteLine("New element: ");
                num = Convert.ToInt32(Console.ReadLine());
                List1.Add(num);
            }
            Console.WriteLine("You have {0} elements.", List1.Length);
            Console.WriteLine("Which elemet do you prefer to get? ");
            try { Console.WriteLine("a = {0}", List1[(Convert.ToInt16(Console.ReadLine()))]); }
            catch { Console.WriteLine("Error: Inex can`t be <0 or bigger than size of list"); }
            Console.ReadKey();
            int[] p = List1.GetArray();
            foreach (int i in p)
                Console.Write("{0} ", i);
            Console.ReadKey();
        }
    }
    public class MyList<T>
    {
        T[] a;
        int length;
        public T[] A
        {
            get { return a; }
        }

        public int Length
        {
            get { return length; }
        }

        public MyList()
        {
            a = new T[1];
            length = 0;
        }

        public void Add(T number)
        {
            if (length != 0)
            {
                T[] b = new T[length];
                for (int i = 0; i < length; i++)
                    b[i] = a[i];
                a = new T[length + 1];
                for (int i = 0; i < length; i++)
                    a[i] = b[i];
            }
            a[length] = number;
            length++;
        }
        
        public T this[int index]
        {
            get { return a[index]; }
        }
    }
    
    public static class MyClass
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            return list.A;
        }
    }
        
}
