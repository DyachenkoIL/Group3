/*
Создайте класс Printer.
В теле класса создайте метод void Print(string value), который выводит на экран значение аргумента.
Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове соответствующего метода их экземпляра, 
строки, переданные в качестве аргументов методов, выводились разными цветами.
Обязательно используйте приведение типов.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ResetColor();
            Console.WriteLine(value);
        }

    }

    internal class YelPrinter: Printer
    {
        public override  void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\nThis is an implicit type conversion \n\n" + value);
        }
    }

    internal class RedPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n\nThis is an implicit type conversion \n\n" + value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new Printer[3];
            arr[0] = new Printer();
            arr[1] = new YelPrinter();
            arr[2] = new RedPrinter();

            foreach (Printer i in arr)
            {
                i.Print("Information... Just information...");
            }

            Console.ReadKey();
        }
    }
}