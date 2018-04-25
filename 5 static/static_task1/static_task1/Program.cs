/*
Создать статический класс – калькулятор
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_task1
{
    static class Calculator
    {
        public static double result;

        static Calculator()
        {
            result = 0;
        }

        public static double Plus(double i)
        {
            return result += i;
        }

        public static double Minus(double i)
        {
            return result -= i;
        }

        public static double Umn(double i)
        {
            return result *= i;
        }

        public static double Del(double i)
        {
            return result /= i;
        }

        public static void Clear()
        {
            result = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            int flag2 = 1;
            while (flag == 1)
            {
                Console.Clear();
                Console.WriteLine("\n1) Введите число \n2) Введите доступное действие \n\nДоступные арифметические действия: + - / * \nc - Очистка (Новый пример) \ne - Выход из калькулятора \nНепредусмотренные варианты ввода рассматриваются как запрос на вывод результата\n");
                double num;
                double num2;
                if (flag2 == 1)
                {
                    do Console.WriteLine("Введите первое число"); while (double.TryParse(Console.ReadLine(), out num) == false);
                    Calculator.Plus(num);
                    flag2 = 0;
                }
                Console.WriteLine("Введите действие");
                switch (Console.ReadLine())
                {
                    case "+":
                        do Console.WriteLine("Введите число"); while (double.TryParse(Console.ReadLine(), out num2) == false);
                        Console.WriteLine("Результат: " + Calculator.Plus(num2));
                        break;
                    case "-":
                        do Console.WriteLine("Введит число"); while (double.TryParse(Console.ReadLine(), out num2) == false);
                        Console.WriteLine("Результат: " + Calculator.Minus(num2));
                        break;
                    case "*":
                        do Console.WriteLine("Введите число"); while (double.TryParse(Console.ReadLine(), out num2) == false);
                        Console.WriteLine("Результат: " + Calculator.Umn(num2));
                        break;
                    case "/":
                        do Console.WriteLine("Введите число"); while (double.TryParse(Console.ReadLine(), out num2) == false);
                        if (num2 != 0)
                            Console.WriteLine("Результат: " + Calculator.Del(num2));
                        else Console.WriteLine("Делить на 0 нельзя! Результат: " + Calculator.result);
                        break;
                    case "c":
                        Calculator.Clear();
                        flag2 = 1;
                        break;
                    case "e":
                        flag = 0;
                        break;
                    default:
                        Console.WriteLine("Результат: " + Calculator.result);
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
