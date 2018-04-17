/*Задание 5 
 * Требуется:  Создать класс User, содержащий информацию о пользователе(логин, имя, фамилия, возраст, дата заполнения анкеты). 
 * Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
 * Реализуйте вывод на экран информации о пользователе.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest5
{
    class User {
        string login, name, surname;
        private DateTime creation_time = DateTime.Now;
        DateTime birthdate = new DateTime();

        public User(string input_login, string input_name, string input_surname, int input_year, int input_month, int input_day) {
            login = input_login;
            name = input_name;
            surname = input_surname;
            birthdate = birthdate.AddYears(input_year - 1);
            birthdate = birthdate.AddMonths(input_month - 1);
            birthdate = birthdate.AddDays(input_day - 1);
        }
        public void Print() {
            Console.WriteLine("Account #1\nRegistration time: " + creation_time + "\nLogin: " + login + "\nName: " + name + "\nSurname: " + surname + "\nBirth Date: " + birthdate + "\nAge: " + (creation_time.Year - birthdate.Year));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[3];
            int[] inputint = new int[3];

            Console.WriteLine("Enter ypur login, name and surname:");
            input[0] = Console.ReadLine();
            input[1] = Console.ReadLine();
            input[2] = Console.ReadLine();
            Console.WriteLine("Enter year, month and day of your birthday:");
            inputint[0] = Int32.Parse(Console.ReadLine());
            inputint[1] = Int32.Parse(Console.ReadLine());
            inputint[2] = Int32.Parse(Console.ReadLine());

            User UserEx = new User(input[0], input[1], input[2], inputint[0], inputint[1], inputint[2]);
            UserEx.Print();

            Console.ReadKey();
        }
    }
}
