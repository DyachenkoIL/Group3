/*
Создайте файл, запишите в него произвольные данные и закройте файл. Затем снова откройте этот
файл, прочитайте из него данные и выведете их на консоль. 

Дяченко Игорь
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace io_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] us = new User[3];
            us[0] = new User(1963,"Andrew","Kokado");
            us[1] = new User(1979,"Kapitalist","Kapitalistoff");
            us[2] = new User(2000,"Igor", "Dyachenko");
            string path = @"D:\special\file.dat";
            
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (User u in us)
                    {
                        writer.Write(u.Number + " ");
                        writer.Write(u.FirstStat + " ");
                        writer.WriteLine(u.EndStat);
                    }   
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            
        }

        struct User
        {
            int Year;
            string Name, Name2;

            public int Number { get { return Year; } }
            public string FirstStat { get { return Name; } }
            public string EndStat { get { return Name2; } }

            public User(int num,string first,string end)
            {
                Year = num;
                Name = first;
                Name2 = end;
            }
        }
    }
}
