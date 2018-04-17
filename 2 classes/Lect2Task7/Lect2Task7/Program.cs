using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect2Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            employees[0] = new Employee("Makhinko", "Vitalii");
            System.Threading.Thread.Sleep(50);
            employees[1] = new Employee("Diachenko","Igor");
            System.Threading.Thread.Sleep(50);
            employees[2] = new Employee("Fomenko","Mykhailo");
            System.Threading.Thread.Sleep(50);
            employees[3] = new Employee("Khoda", "Anton");
            System.Threading.Thread.Sleep(50);
            employees[4] = new Employee("Prokofiev", "Tykhon");
            for (int i = 0;i<5;i++)
            {
                Console.WriteLine( employees[i].Information());
                
            }
            Console.ReadKey();
        }
        
    }

    class Employee
    {
        string first_name, second_name, position;
        int expierense;
        double koef, tax;
        public Employee(string fam, string im)
        {
            second_name = fam;
            first_name = im;
            Random rnd = new Random();
            int n = rnd.Next(1, 4);
            switch (n)
            {
                case 1: position = "Director"; koef = 2.5; break;
                case 2: position = "Leader"; koef = 1.5; break;
                case 3: position = "janitor"; koef = 0.9; break;
                case 4: position = "I"; koef = 0; break;
            }
            n = rnd.Next(1, 50);
            expierense = n;
        }
        public double Oklad()
        {
            double oklad = 37*koef+ expierense*20;
            tax = 0.15 * oklad;
            return oklad;
        }
        public string Information()
        {
            string information = "Employee "+second_name+" "+first_name+ " have salary "+Oklad()+ " and "+expierense+ " years of expierence. Pay tax: "+tax+". He`s "+position+".";
            return information;
        }
    }
}
