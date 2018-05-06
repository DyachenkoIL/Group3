/*
Создайте на диске 100 директорий с именами от Folder_0 до Folder_99, затем удалите их.
Махинько Виталий
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace io_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    string path = @"E:\test\Folder_" + i;
                    Directory.CreateDirectory(path);
                }
                Console.ReadKey();
                for (int i = 0; i < 100; i++)
                {
                    string path = @"E:\test\Folder_" + i;
                    Directory.Delete(path);
                }
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
