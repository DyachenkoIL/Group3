/*Требуется:
Создать класс Converter.
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне - public Converter(double usd, double eur, double rub).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
также программа должна производить конвертацию из указанных валют в гривну.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{   class Converter
    {
        double Usd_Grn, Eur_Grn, Rub_Grn;
        public Converter(double usd, double eur, double rub)
        {
            Usd_Grn = usd;
            Eur_Grn = eur;
            Rub_Grn = rub;
        }

        public void ConvFromGrn(double val, string cur)
        {
            if ((cur == "USD") || (cur == "usd"))
                Console.WriteLine("\nThis is in USD:  " + Math.Round(val / Usd_Grn, 4));
            else if ((cur == "EUR") || (cur == "eur"))
                Console.WriteLine("\nThis is in EUR:  " + Math.Round(val / Eur_Grn, 4));
            else if ((cur == "RUB") || (cur == "rub"))
                Console.WriteLine("\nThis is in RUB:  " + Math.Round(val / Rub_Grn, 4));
            else Console.WriteLine("\nWe don`t know this currency.");
        }

        public void ConvInGrn(double val, string cur)
        {
            if ((cur == "USD") || (cur == "usd"))
                Console.WriteLine("\nThis is in GRN:  " + Math.Round(val * Usd_Grn, 4));
            else if ((cur == "EUR") || (cur == "eur"))
                Console.WriteLine("\nThis is in GRN:  " + Math.Round(val * Eur_Grn, 4));
            else if ((cur == "RUB") || (cur == "rub"))
                Console.WriteLine("\nThis is in GRN:  " + Math.Round(val * Rub_Grn, 4));
            else Console.WriteLine("\nWe don`t know this currency.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter exchange rates USD - GRN, EUR - GRN, RUB - GRN : ");
            Converter Conv = new Converter(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            int flag = 1;
            int flag2;
            double money;
            string currency;

            while (flag == 1)
            {
                Console.Clear();
                Console.WriteLine("\n1. Convert GRN in another currency \n2. Convert another currency in UAH \n3. EXIT");
                money = -1;
                flag2 = 0;
                do
                {
                    Console.WriteLine("What r u want?");
                    flag2 = Convert.ToInt32(Console.ReadLine());
                } while ((flag2 < 1) && (flag2>3));

                switch (flag2)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("How much money do you have?");
                            money = Convert.ToDouble(Console.ReadLine());
                        } while (money < 0);
                        Console.WriteLine("In which currency do you want to convert? (USD, EUR, RUB)");
                        currency = Console.ReadLine();
                        Conv.ConvFromGrn(money, currency);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("How much money do you have?");
                            money = Convert.ToDouble(Console.ReadLine());
                        } while (money < 0);
                        Console.WriteLine("From which currency do you want to convert? (USD, EUR, RUB)");
                        currency = Console.ReadLine();
                        Conv.ConvInGrn(money, currency);
                        break;
                    case 3: Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Something more? ('y' if yes)");
                if (Console.ReadLine() != "y")
                    flag = 0;
            }
            Console.ReadKey();
        }
    }
}
