using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пользователь вводит слово «мяу» или слово «гав» если слово введенное пользователем «мяу» вывести на экран «Покорми кота» иначе «Погуляй с собакой»");
            int flag = 1;
            string golos;
            while (flag == 1)
            {
                Console.WriteLine("Введите гав или мяу");
                golos = Console.ReadLine();
                switch (golos)
                {
                    case "гав":
                        Console.WriteLine("Погуляй с собакой");
                        break;
                    case "мяу":
                        Console.WriteLine("Покорми кота");
                        break;
                    case "Гав":
                        Console.WriteLine("Погуляй с собакой");
                        break;
                    case "Мяу":
                        Console.WriteLine("Покорми кота");
                        break;
                    case "ГАВ":
                        Console.WriteLine("Погуляй с собакой");
                        break;
                    case "МЯУ":
                        Console.WriteLine("Покорми кота");
                        break;
                    default:
                        Console.WriteLine("Надо было ввести гав или мяу");
                        break;
                }
                Console.WriteLine("Желаете продолжить? (y если Да)");
                string fl = Console.ReadLine();
                if (fl != "y")
                {
                    flag++;
                }
            }
        }
    }
}
