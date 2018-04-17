using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы организатор лотереи. Пользователь вводит ставку. Вы бросаете 12-гранный кубик. Если выпадают значения от 1 до 5, пользователь проиграл. Если выпадают значения от 6 до 8, пользователь получает свою ставку обратно. Если выпало от 9 до 11, пользователь получает двойную ставку, а если выпало 12 - ставку умноженную на 10. После окончания игры покажите пользователю, сколько он выиграл.");
            int itog = 0;
            int flag = 1;
            while (flag == 1)
            {
                Console.WriteLine("Введите свою ставку");
                int stavka = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int result = rnd.Next(1, 12);
                Console.WriteLine("На кубике выпало {0}", result);
                if (result <= 5)
                {
                    Console.WriteLine("Вы проиграли свою ставку (теряете {0})", stavka);
                    itog -= stavka;
                }
                else if (result <= 8) { Console.WriteLine("Вы получаете свою ставку обратно ({0})", stavka); }
                else if (result <= 11)
                {
                    Console.WriteLine("Вы удваиваете свою ставку (получаете {0})", stavka * 2);
                    itog += (stavka * 2);
                }
                else
                {
                    Console.WriteLine("Ваша ставка умножается на 10 (получаете {0})", stavka * 10);
                    itog += (stavka * 10);
                }
                Console.WriteLine("Общий итог игры: " + itog);
                Console.WriteLine("Хотите сыграть ещё? (введите 'да', если хотите)");
                if ((Console.ReadLine()) != "да") flag = 0;
            }
        }
    }
}