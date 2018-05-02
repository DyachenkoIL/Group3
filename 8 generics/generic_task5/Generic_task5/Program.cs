/*Создайте класс CarCollection<T>.Реализуйте в простейшем приближении возможность использования его
экземпляра для создания парка машин.Минимально требуемый интерфейс взаимодействия с экземпляром,
должен включать метод добавления машин с названием машины и года ее выпуска, индексатор для получения
значения элемента по указанному индексу и свойство только для чтения для получения общего количества
элементов.
Создайте метод удаления всех машин автопарка.
Miroshnichenko Denis
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_task5
{
    interface Car
    {
        string CarName { get; set; }
        int YearOfCreation { get; set; }
    }

    class CarColletion<T> where T: Car, new()
    {
        List<T> Car_list = new List<T>();

        public void Add(string Name, int Year)
        {
            Car_list.Add(new T() { CarName = Name, YearOfCreation = Year});
        }

        public T this[int num]
        {
            get { return Car_list[num]; }
            set { Car_list[num] = value; }
        }

        public int Count
        {
            get { return Car_list.Count; }
        }

        public void Clear()
        {
            Car_list.Clear();
        }
    }

    class CarA : Car
    {
        public string CarName { get; set; }
        public int YearOfCreation { get; set; }
        public override string ToString()
        {
            return $"{CarName} {YearOfCreation}";//"Name: " + CarName + "\nYear: " + YearOfCreation;
        }
    }

    class CarB : Car
    {
        public string CarName { get; set; }
        public int YearOfCreation { get; set; }
        public override string ToString()
        {
            return $"{CarName} {YearOfCreation}";//"Name: " + CarName + "\nYear: " + YearOfCreation;
        }
    }

    class Program
    {
        static void Create<T>() where T: Car, new()
        {
            var collection = new CarColletion<T>();
            collection.Add("BMW", 1988);
            collection.Add("Mersedes", 2015);
            Console.WriteLine("Typeof collection: " + typeof(T).Name);
            for(int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }
        }
        static void Main(string[] args)
        {
            Create<CarA>();
            Create<CarB>();
            
            Console.ReadKey();
        }
    }
}
