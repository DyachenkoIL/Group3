using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] train = new Train[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter number of {0} train:", i + 1);
                train[i].Number = Convert.ToInt32( Console.ReadLine());
                Console.Write("Enter first station of {0} train:",i+1);
                train[i].FirstStation = Console.ReadLine();
                Console.Write("Enter end station of {0} train:",i+1);
                train[i].EndStation = Console.ReadLine();
            }
            train = train.SortNumb();
            Console.WriteLine("Enter the number of train what you would like to see:");
            int num = Convert.ToInt32(Console.ReadLine());
            bool enter = false;
            Console.Clear();
            for (int i = 0; i < 8; i++)
            {
                if (num == train[i].Number)
                {
                    Console.WriteLine("|Num    | FirstStation  |    EndStation |");
                    Console.WriteLine("|{0}\t|{1}\t\t|{2}\t\t|", train[i].Number, train[i].FirstStation, train[i].EndStation);
                    enter = true;
                }       
            }
            if (!enter)
                Console.WriteLine("We don`t have this train:(");
            Console.ReadKey();
        }
        
    }
    public struct Train
    {
        
        public string FirstStation
        {
            set; get;
        }
        public string EndStation
        {
            set; get;
        }
        public int Number
        {
            set; get;
        }

    }
    public static class Sort
    {
        public static Train[] SortNumb(this Train[] train)
        {
            Train temp;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (train[j].Number > train[j + 1].Number)
                    {
                        temp = train[j];
                        train[j] = train[j + 1];
                        train[j + 1] = temp;
                    }
                }
            }
            
            return train;
        }
    }
}
