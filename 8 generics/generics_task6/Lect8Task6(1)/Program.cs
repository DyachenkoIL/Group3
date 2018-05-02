/*
Создайте класс Dictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра аналогично экземпляру класса Dictionary из пространства имен
System.Collections.Generic. Минимально требуемый интерфейс взаимодействия с экземпляром, должен
включать метод добавления пар элементов, индексатор для получения значения элемента по указанному
индексу и свойство только для чтения для получения общего количества пар элементов.

Makhinko Vitalii
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect8Task6_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> str = new Dictionary<string, string>();
            string key;
            string value;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter key");
                key = Console.ReadLine();
                Console.WriteLine("Enter value");
                value = Console.ReadLine();
                str.Add(key, value);
            }
            Console.WriteLine("You have {0} elements", str.Count);
            Console.Write("Enter key to search element ");
            try { Console.WriteLine(str[Console.ReadLine()]); }
            catch
            {
                Console.WriteLine("Error: Dictionary doesn`t have this element");
            }
            Console.ReadKey();
        }
    }
    class Dictionary <TKey,TValue>
    {
        List<TKey> keys;
        List<TValue> values;
        public int Count
        {
            get
            {
                return keys.Count;
            }
        }
        public Dictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }
        public void Add(TKey key,TValue value)
        {
            if (keys.BinarySearch(key) >= 0)
            {
                Console.WriteLine("Element didn`t save. You have this key.");
                return;
            }

            keys.Add(key);
            values.Add(value);
        }
        public TValue this[TKey index]
        {
            get { return values[keys.BinarySearch(index)]; }
            set { values[keys.BinarySearch(index)] = value; }
        }

    }
        
}
