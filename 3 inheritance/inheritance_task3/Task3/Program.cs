/*
Создать класс Vehicle.
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска).
Создайте 3 производных класса Plane, Саг и Ship.
Для класса Plane должна быть определена высота и количество пассажиров.
Для класса Ship — количество пассажиров и порт приписки.
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vehicle
{
    internal class Vehicle
    {
        private int coordinateX, coordinateY;
        private int price, speed, year_of_construction;
        public int CoordinateX
        {
            get { return coordinateX; }
            set { if (value < 0) coordinateX = 0;
                else coordinateX = value; }
        }

        public int CoordinateY
        {
            get { return coordinateY; }
            set { if (value < 0) coordinateY = 0;
                else coordinateY = value; }
        }

        public int Price
        {
            get { return price; }
            set {
                if (value < 0) price = 0;
                else price = value; }
        }

        public int Speed
        {
            get { return speed; }
            set {
                if (value < 0) speed = 0;
                else speed = value; }
        }

        public int Year
        {
            get { return year_of_construction; }
            set {
                if (value < 0) year_of_construction = 0;
                else year_of_construction = value; }
        }

        public void Place(int CoordinateX, int CoordinateY)
        {
            this.CoordinateX = CoordinateX;
            this.coordinateY = CoordinateY;
        }

        public Vehicle(int Speed)
        {
            this.Speed = Speed;
        }
    }

    class Plane : Vehicle
    {
        public int HeightLimit { get; set; }
        public int Passengers { get; set; }
        public Plane(int Speed)
            : base(Speed)
        {
            HeightLimit = 300;
            Passengers = 100;
        }
    }

    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }
        public Ship(int Speed)
            : base(Speed)
        {
            Passengers = 500;
            Port = "Port A";
        }
    }

    class Car : Vehicle
    {
        public Car(int Speed)
            : base(Speed) { }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("****Самолёт****");
            var plane = new Plane(400) { Year = 2001, Price = 1000000, HeightLimit = 2000, Passengers = 10};
            plane.Place(10000, 20000);
            Console.WriteLine("Характеристики\n");
            Console.WriteLine("Стоимость: {0}", plane.Price.ToString());
            Console.WriteLine("Год выпуска: {0}", plane.Year.ToString());
            Console.WriteLine("Скорость: {0}", plane.Speed.ToString());
            Console.WriteLine("Высота полёта: {0}", plane.HeightLimit.ToString());
            Console.WriteLine("Число пассажиров: {0}", plane.Passengers.ToString());
            Console.WriteLine("Координаты X: {0}, Y: {1}", plane.CoordinateX.ToString(), plane.CoordinateY.ToString());

            Console.WriteLine("\n****Машина****");
            var car = new Car(300) { Price = 88888, Year = 2000};
            car.Place(11000, 23000);
            Console.WriteLine("Характеристики\n");
            Console.WriteLine("Стоимость: {0}", car.Price.ToString());
            Console.WriteLine("Год выпуска: {0}", car.Year.ToString());
            Console.WriteLine("Скорость: {0}", car.Speed.ToString());
            Console.WriteLine("Координаты X: {0}, Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());

            Console.WriteLine("\n****Корабль****");
            var ship = new Ship(90) { Price = 8000000, Year = 1990, Port = "ISD Port", Passengers = 1000 };
            ship.Place(15000, 13000);
            Console.WriteLine("Характеристики\n");
            Console.WriteLine("Стоимость: {0}", ship.Price.ToString());
            Console.WriteLine("Год выпуска: {0}", ship.Year.ToString());
            Console.WriteLine("Скорость: {0}", ship.Speed.ToString());
            Console.WriteLine("Число пассажиров: {0}", ship.Passengers.ToString());
            Console.WriteLine("Порт приписки: {0}", ship.Port.ToString());
            Console.WriteLine("Координаты X: {0}, Y: {1}", ship.CoordinateX.ToString(), ship.CoordinateY.ToString());

            Console.ReadKey();
        }
    }
}
