/*Создайте класс MyDictionary<TKey,TValue>. Реализуйте в простейшем приближении возможность
использования его экземпляра Минимально требуемый интерфейс взаимодействия с экземпляром, должен
включать метод добавления пар элементов, индексатор для получения значения элемента по указанному
индексу и свойство только для чтения для получения общего количества пар элементов.
Miroshnichenko Denis*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_task3
{
    class MyDitictionary<Tkey, TValue>
    {
        private int counter = 0;
        private Tkey[] arr_key = null;
        private TValue[] arr_value = null;

        private int Counter
        {
            get { return this.counter; }
        }

        public void Add(Tkey ikey, TValue ivalue)
        {
            this.counter++;

            Array.Resize(ref arr_key, counter);
            arr_key[counter - 1] = ikey;

            Array.Resize(ref arr_value, counter);
            arr_value[counter - 1] = ivalue;
        }

        public TValue this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < arr_key.Length; i++)
                {
                    if (key.Equals(arr_key[i]))
                    {
                        ind = i;
                    }
                }
                return arr_value[ind];
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDitictionary<int, string> md = new MyDitictionary<int, string>();
            md.Add(0, "Hello");
            md.Add(1, "there,");
            md.Add(2, "Everyone");

            Console.WriteLine(md[1]);
            Console.ReadKey();
        }
    }
}
