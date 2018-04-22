/*
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из
интерфейсов создайте по 3 метода void Play() / void Pause() / void
Stop() и void Record() / void Pause() / void Stop() соответственно.
Создайте производный класс Player от базовых интерфейсов
IPlayable и IRecodable.
Написать программу, которая выполняет проигрывание и запись.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    public class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Music plays");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Music on pause");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music stopped");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Recording started");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Record on pause");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record stopped");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int flag1 = 1;
            int flag2, flag3, flag4;
            Player player = new Player();
            while (flag1 == 1)
            {
                Console.Clear();
                flag2 = 1;
                Console.WriteLine("\nPROGRAMM START \nWhat r u want to open ? \n1 - Player \n2 - Recorder \n3 - EXIT");
                switch (Console.ReadLine())
                {
                    case "1":
                        flag4 = 1;
                        while (flag2 == 1)
                        {
                            flag3 = 1;
                            if (flag4 == 1)
                                Console.WriteLine("\nWhat next? \n1 - Play \n4 - Main menu");
                            else
                                Console.WriteLine("\nWhat next? \n1 - Resume play \n4 - Main menu");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    ((IPlayable)player).Play();
                                    while (flag3 == 1)
                                    {
                                        Console.WriteLine("\nWhat next? \n2 - Pause \n3 - Stop");
                                        switch (Console.ReadLine())
                                        {
                                            case "2":
                                                ((IPlayable)player).Pause();
                                                flag3 = 0;
                                                flag4 = 0;
                                                break;
                                            case "3":
                                                ((IPlayable)player).Stop();
                                                flag3 = 0;
                                                flag4 = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case "4":
                                    flag2--;
                                    break;
                            }
                        }
                        break;
                    case "2":
                        flag4 = 1;
                        while (flag2 == 1)
                        {
                            flag3 = 1;
                            if (flag4==1)
                                Console.WriteLine("\nWhat next? \n1 - Record \n4 - Main menu");
                            else
                                Console.WriteLine("\nWhat next? \n1 - Resume record \n4 - Main menu");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    ((IRecodable)player).Record();
                                    while (flag3 == 1)
                                    {
                                        Console.WriteLine("\nWhat next? \n2 - Pause \n3 - Stop");
                                        switch (Console.ReadLine())
                                        {
                                            case "2":
                                                ((IRecodable)player).Pause();
                                                flag3 = 0;
                                                flag4 = 0;
                                                break;
                                            case "3":
                                                ((IRecodable)player).Stop();
                                                flag3 = 0;
                                                flag4 = 1;
                                                break;
                                        }
                                    }
                                    break;
                                case "4":
                                    flag2--;
                                    break;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("EXIT \n TY 4 our programm using!");
                        flag1--;
                        break;
                    default:
                        Console.WriteLine("Unknown command | | | Try again");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
