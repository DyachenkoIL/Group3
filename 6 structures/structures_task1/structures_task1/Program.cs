/*
Создайте структуру с именем - Notebook.
Поля структуры: модель, производитель, цена.
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого
полей на экран*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structures_task1
{
    struct Notebook
    {
        public string Model
        {
            set; get;
        }
        public string Made
        {
            set; get;
        }
        public double Price
        {
            set; get;
        }

        public Notebook(string Model, string Made, double Price)
        {
            this.Model = Model;
            this.Made = Made;
            this.Price = Price;
        }

        public void printVal()
        {
            Console.WriteLine("\n\nProduct: \n  Model: {0} \n  Country of production: {1} \n  Price: {2}", Model, Made, Price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many products do you want to add?");
            int kol = Convert.ToInt32(Console.ReadLine());
            Notebook[] note = new Notebook[kol];
            for (int i = 0; i < kol; i++)
            {
                Console.Write("\nEnter model of {0} product:", i + 1);
                note[i].Model = Console.ReadLine();
                Console.Write("Enter country of production of {0} product:", i + 1);
                note[i].Made = Console.ReadLine();
                Console.Write("Enter price of {0} product:", i + 1);
                double nm;
                while (!double.TryParse(Console.ReadLine(), out nm))
                    Console.WriteLine("\nEnter numeric value. Try again!");
                note[i].Price = nm;
            }
            Console.Clear();
            foreach (Notebook n in note)
                n.printVal();
            Console.ReadKey();
        }
    }
}
