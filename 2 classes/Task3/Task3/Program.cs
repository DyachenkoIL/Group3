/*Требуется:
Создать класс Book. 
Создать классы Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Title Nazvanie;
        Author Pisatel;
        Content Plan;

        public Book(string Naz, string Pis, string Pl)
        {
            Nazvanie = new Title(Naz);
            Pisatel = new Author(Pis);
            Plan = new Content(Pl);
        }

        public void Show()
        {
            Nazvanie.Show();
            Pisatel.Show();
            Plan.Show();
        }

    }
    class Title
    {
        public Title(string Naz)
            {
                this.Nazva = Naz;
            }
        public string Nazva { get; set;}
        public void Show ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTitle: " + Nazva);
            Console.ResetColor();
        }
    }

    class Author
    {   
        public Author(string Pis)
            {
                this.Imja = Pis;
            }
            public string Imja { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nAuthor: " + Imja);
            Console.ResetColor();
        }
    }

    class Content
    {
        public Content(string Pl)
            {
                this.Sutj = Pl;
            }
            public string Sutj { get; set; }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAuthor: " + Sutj);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Title, Author and Content: ");
            Book Kniga = new Book(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            Console.Clear();
            Kniga.Show();
            Console.ReadKey();
        }
    }
}
