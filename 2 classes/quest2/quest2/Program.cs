/*Задание 2  
 *Требуется: Создать класс с именем Rectangle.  
 *В теле класса создать два поля, описывающие длины сторон double side1, side2.  
 *Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.  
 *Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator(). 
 *Создать два свойства double Area и double Perimeter с одним методом доступа get.  
 *Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest2
{

    class Rectangle {
        double side1, side2;
        public double AreaCalculator() {
            return side1 * side2;
        }
        public double PerimeterCalculator() {
            return (2 * side1) + (2 * side2);
        }
        public Rectangle(double input_side1, double input_side2) {
            side1 = input_side1;
            side2 = input_side2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            double[] size = new double[2];
            Console.WriteLine("Type height of Rectangle: ");
            size[0] = Double.Parse(Console.ReadLine());
            Console.WriteLine("\nType width of Rectangle: ");
            size[1] = Double.Parse(Console.ReadLine());
            Rectangle Rect = new Rectangle(size[0], size[1]);
            Console.WriteLine("\nRectangle area: "+ Rect.AreaCalculator() + "\nRectangle perimeter: " + Rect.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
