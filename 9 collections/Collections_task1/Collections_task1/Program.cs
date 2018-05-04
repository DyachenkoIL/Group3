/*Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает коллекцию всех
четных чисел массива. Для формирования коллекции используйте оператор yield
Игорь Дяченко
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            Random rnd1 = new Random();
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd1.Next(0, 10);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            foreach(int value in EvenCollection(array))
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }

        private static List<int> EvenCollection(int[] arr)
        {
            List<int> MyCol = new List<int>();
            foreach(int even in GetEnum(arr))
            {
                MyCol.Add(even);
            }
            /*foreach(int even in arr)
            {
                if(even % 2==0&& even != 0)
                {
                    MyCol.Add(even);
                }
            }*/
            return MyCol;
        }
        public static IEnumerable<int> GetEnum(int[] arr)
        {
            foreach(int even in arr)
            {
                if (even % 2 == 0 && even != 0) { yield return even; }
            }
        }
    }
}


