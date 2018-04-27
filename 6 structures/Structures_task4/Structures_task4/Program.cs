/*Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество
дней до его следующего дня рождения.
Miroshnichenko Denis*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_task4
{ 
    class Program
    {
        static int GetBirthDay(int min_value, int max_value, string value_name)
        {
            int value = 0;
            while (value < min_value || value > max_value)
            {
                Console.Write("Type " + value_name + " of your birthday here: ");
                value = Int32.Parse(Console.ReadLine());
                if (value < 1 || value > max_value)
                {
                    Console.Write("Error, '" + value_name + "' must be between " + min_value + " and " + max_value + "!\nTry again: ");
                    value = Int32.Parse(Console.ReadLine());
                }
            }
            return value;
        }
        static void Main(string[] args)
        {
            int year = GetBirthDay(1, 9999, "year");
            int month = GetBirthDay(1, 12, "month");
            Console.Write("Count Days in curr month: " + DateTime.DaysInMonth(year, month) + "\n");
            int day = GetBirthDay(1, DateTime.DaysInMonth(year, month), "day");
            DateTime n_birthday = new DateTime(DateTime.Now.Year, month, day);
            //DateTime today = new //DateTime(2018, 4, 27);
            TimeSpan timeSpan = n_birthday.Subtract(DateTime.Now);
            int dayoffset;
            if (timeSpan.Days < 0)
            {
                int curryeardayscount = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;
                dayoffset = curryeardayscount - DateTime.Now.Day;
            }  else
            {
                dayoffset = timeSpan.Days;
            }

            Console.WriteLine("Days to the next birthday: " + dayoffset);

            Console.ReadKey();
        }
    }
}
