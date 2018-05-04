/*Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность использования ее
экземпляра аналогично экземпляру класса List<T>. Минимально требуемый интерфейс взаимодействия с
экземпляром, должен включать метод добавления элемента, индексатор для получения значения элемента по
указанному индексу и свойство только для чтения для получения общего количества элементов. Реализуйте
возможность перебора элементов коллекции в цикле foreach.
Miroshnichenko Denis*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_task2
{
    
    class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] members = new T[0];
        int index = -1;

        //реализация методов IEnumerable, IEnumerator для перебора коллекции циклом foreach
        public IEnumerator GetEnumerator() { return this; }

        public void Reset() { index = -1; }

        public bool MoveNext()
        {
            if(index == members.Length - 1) { Reset(); return false; }

            index++;
            return true;
        }

        public object Current
        {
            get { return members[index]; }
        }

        //Возвращаем элемент, по его номеру в коллекции
        public T this[int i]
        {
            get
            {
                if (i > members.Length && i < 0) throw new IndexOutOfRangeException();
                return members[i];
            }
            set
            {
                if (i > members.Length && i < 0) throw new IndexOutOfRangeException();
                members[i] = value;
            }
        }

        //Добавление элемента
        public void Add(T value)
        {
            T[] newmember = new T[members.Length + 1];
            members.CopyTo(newmember, 0);
            newmember[members.Length] = value;
            members = newmember;
        }

        //Удаление элемента
        public bool Remove(T value)
        {
            int index = Array.IndexOf(members, value);
            if (index == -1) return false;
            T[] newmember = new T[members.Length - 1];
            int offset = 0;
            for(int i = 0; i < members.Length; i++)
            {
                if(i == index)
                {
                    offset++;
                    continue;
                }
                newmember[i - offset] = members[i];
            }
            members = newmember;
            return true;
        }

        //Кол-во элементов
        public int Count { get { return members.Length; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> testlist = new MyList<int>();
            testlist.Add(387);
            testlist.Add(2345);
            testlist.Add(45);
            testlist.Add(23);
            Console.WriteLine(testlist[1] + " " + testlist.Count + " " + testlist.Remove(23) + " " + testlist.Count);
            foreach(int str in testlist)
            {
                Console.WriteLine(str);
            }
            
            Console.ReadKey();
        }
    }
}
