/*
Создайте класс MyClass<T>, содержащий статический фабричный метод - T FacrotyMethod(), который
будет порождать экземпляры типа, указанного в качестве параметра типа (указателя места заполнения типом – Т). 

Дяченко Игорь
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics_task1
{
    public class MyFactory<T> where T : new()
    {
        public static T Vozvrat()
        {
            return new T();
        }
    }

    public class MyType
    {
        public int a;

        public MyType()
        {
        }
    }

    public class MyType2
    {
        public int a;

        public MyType2()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var instance = MyFactory<MyType>.Vozvrat();
            Console.WriteLine(instance.GetType());

            var instance2 = MyFactory<MyType2>.Vozvrat();
            Console.WriteLine(instance2.GetType());

            Console.ReadKey();
        }
    }
}