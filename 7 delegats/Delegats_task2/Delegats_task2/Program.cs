/*Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub –
вычитание, Mul – умножение, Div – деление). Каждый лямбда оператор должен принимать два аргумента и
возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль.
Написать программу, которая будет выполнять арифметические действия указанные пользователем.
Miroshnihenko Denis
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegats_task2
{
    public delegate double Calculate(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            string isContinue = "y";
            while(isContinue == "y")
            {
                Console.Write("Введите действие ('+', '-', '*', '/'): ");
                string a = Console.ReadLine();
                Console.Write("Первое число: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Второе число: ");
                double y = Convert.ToDouble(Console.ReadLine());
                
                switch(a)
                {
                    case "+": Calculate add = (c, b) => { return c + b; };
                        double res = add(x, y);
                        Console.WriteLine("Ответ:{0}", res);
                        break;
                    case "-":
                        Calculate sub = (c, b) => { return c - b; };
                        double res1 = sub(x, y);
                        Console.WriteLine("Ответ:{0}", res1);
                        break;
                    case "*":
                        Calculate Mul = (c, b) => { return c * b; };
                        double res2 = Mul(x, y);
                        Console.WriteLine("Ответ:{0}", res2);
                        break;
                    case "/":
                        Calculate Div = (c, b) => b == 0 ? 0 : c / b;
                        double res3 = Div(x, y);
                        Console.WriteLine("Ответ:{0}", res3);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Неверное действие.");
                        break;
                }

                Console.WriteLine("Продолжить? (y/n)");
                isContinue = Console.ReadLine();
                if(isContinue == "y" || isContinue == "n")
                {
                    Console.Clear();
                } else
                {
                    Console.WriteLine("Ошибка!");
                    break;
                }
            }
        }
    }
}
