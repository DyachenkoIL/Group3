using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            do
            {
                Console.WriteLine("How much money do you have");
                money = Convert.ToInt32(Console.ReadLine());
            } while (money < 0);
            string currency;
            Console.WriteLine("In which currency?");
            currency = Console.ReadLine();
            if (currency == "UAH")
                Console.WriteLine("This is USD "+ Math.Round(money) / 26+ "\nThis is EUR "+Math.Round( money / 32));
            else if (currency == "USD")
                Console.WriteLine("This is UAH "+ money * 26+ "\nThis is EUR "+Math.Round( money / 0.81,3));
            else if (currency == "EUR")
                Console.WriteLine("This is USD "+Math.Round( money * 0.81,3)+ "\nThis is UAH "+ money * 32);
            else Console.WriteLine("We don`t know this currency:(");
            Console.ReadKey();
        }
    }
}
