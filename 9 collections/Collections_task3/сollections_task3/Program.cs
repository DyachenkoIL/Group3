/*
 * Создайте коллекцию MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования ее экземпляра аналогично экземпляру класса Dictionary<TKey,TValue>. Минимально
требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления элемента,
индексатор для получения значения элемента по указанному индексу и свойство только для чтения для
получения общего количества элементов. Реализуйте возможность перебора элементов коллекции в цикле
foreach.

Makhinko Vitalii
*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сollections_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> mydictionary = new MyDictionary<string, string>();
            string key, value;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter key :");
                key = Console.ReadLine();
                Console.Write("Enter value :");
                value = Console.ReadLine();
                mydictionary.Add(key, value);
            }
            Console.WriteLine("Enter key");
            try { Console.WriteLine("Value = "+mydictionary[Console.ReadLine()]); }
            catch
            {
                Console.WriteLine("Error: Dictionary doesn`t have this element");
            }
            foreach (Para<string, string> e in mydictionary)
                Console.WriteLine("{0}  {1}",e.Key,e.Value);
            Console.ReadKey();
        }

        class MyDictionary<TKey,TValue> : IEnumerable
        {
            private List<Para<TKey,TValue>> paras = new List<Para<TKey, TValue>>();
            public TValue this[TKey index]
            {
                get
                {
                    int ind = -1;
                    for (int i = 0; i < Count; i++)
                        if (index.Equals(paras[i].Key))
                            ind = i;
                    return paras[ind].Value;

                }
            }

            public int Count
            {
                get;set;
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return paras.GetEnumerator();
            }

            public void Add(TKey key,TValue value)
            {
                if (Count != 0)
                    for (int i = 0;i<Count;i++)
                        if (key.Equals(paras[i].Key))
                            {
                            Console.WriteLine("Element didn`t save. You have this key.");
                            return;
                            }
                Para<TKey,TValue> para = new Para<TKey,TValue>();
                para.Key = key;
                para.Value = value;
                paras.Add(para);
                Count++;
            }


        }

        public class Para <TKey,TValue>
        {
            public TValue Value
            {
                get;set;
            }
            public TKey Key
            {
                get;set;

            }
            

        }
    }
}
