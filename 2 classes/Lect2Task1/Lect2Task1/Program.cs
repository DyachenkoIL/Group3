using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect2Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            Console.WriteLine("Enter index: ");
            adress.Index = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            adress.Country = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            adress.City = Console.ReadLine();
            Console.WriteLine("Enter street: ");
            adress.Street = Console.ReadLine();
            Console.WriteLine("Enter house: ");
            adress.House = Console.ReadLine();
            Console.WriteLine("Enter appartment: ");
            adress.Appartment = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Index: {0}. Country: {1}. City: {2}. Adress: str.{3}, h.{4}, app.{5}",adress.Index, adress.Country, adress.City, adress.Street, adress.House, adress.Appartment);
            Console.ReadKey();
            
        }
    }
    class Adress
    {
        string index, country, city, street, house, appartment;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value.Length > 5)
                    index = value.Substring(0, 5);
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Appartment
        {
            get
            {
                return appartment;
            }
            set
            {
                appartment = value;
            }
        }
    }
}
