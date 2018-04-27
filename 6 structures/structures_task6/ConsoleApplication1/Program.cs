/*
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за
месяц.
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать
или нет сотруднику премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена
премия. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        enum Post
        {
            janitor = 80,
            porter = 120,
            chief = 90
        }
        
        static class Accauntant
        {
            static public bool AskForBonus(Post worker, int hours)
            {
                return ((int)worker<hours);
            }
        }

        static void Main(string[] args)
        {   
            Post ourchief=Post.chief;
            if (Accauntant.AskForBonus(ourchief, 80))
                Console.WriteLine(ourchief + " должен получать премию.");
            else Console.WriteLine(ourchief + " не должен получать премию.");

            Post ourjanitor = Post.janitor;
            if (Accauntant.AskForBonus(ourjanitor, 100))
                Console.WriteLine(ourjanitor + " должен получать премию.");
            else Console.WriteLine(ourjanitor + " не должен получать премию.");

            Console.ReadKey();
        }
    }
}
