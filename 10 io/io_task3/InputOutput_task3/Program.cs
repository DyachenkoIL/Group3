/*
 Напишите приложение для поиска заданного файла на диске. 
 Добавьте код, использующий класс FileStream и позволяющий просматривать файл в текстовом окне. 
 В заключение добавьте возможность сжатия найденного файла.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO.Compression;

namespace InputOutput_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started: " + DateTime.Now.ToLongTimeString() + "\n");

            Console.Write("Type filename here: ");
            string str1 = Console.ReadLine();
            Console.Write("Type directory to search here: ");
            string str2 = Console.ReadLine();

            Regex file = new Regex(@"" + str1 + "");
            DirectoryInfo dir = new DirectoryInfo(@"" + str2 + ":\\");

            FileInfo[] f_info = Search(dir, file);
            Console.WriteLine("{0} | {1}", f_info[0].Directory.Name, f_info[0].Name);

            Console.WriteLine("\nFinished: " + DateTime.Now.ToLongTimeString());

            OpenFile(f_info[0]);

            Compress(f_info[0]);

            //Console.Write("\nType file № to open it: ");
            //int filenum = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }

        

        static FileInfo[] Search(DirectoryInfo dir, Regex file)
        {
            FileInfo[] output = new FileInfo[0];
            try
            {
                FileInfo[] fi = dir.GetFiles();
                foreach (FileInfo i in fi)
                {
                    if (file.IsMatch(i.Name))
                    {
                        FileInfo[] newoutput = new FileInfo[output.Length + 1];
                        output.CopyTo(newoutput, 0);
                        newoutput[output.Length] = i;
                        output = newoutput;
                    }
                    DirectoryInfo[] dirs = dir.GetDirectories();

                    foreach (DirectoryInfo di in dirs)
                    {
                        Search(di, file);
                    }
                }
            }
            catch (UnauthorizedAccessException) { }
            return output;
        }

        static void OpenFile(FileInfo fi)
        {
            string path = fi.DirectoryName + fi.Name;
            StreamReader strread = fi.OpenText();
            string s = "";
            Console.WriteLine("text from file:");
            while((s = strread.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            strread.Close();
            //FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
        }

        static void Compress(FileInfo fi)
        {
            using (FileStream inFile = fi.OpenRead())
            {
                if ((File.GetAttributes(fi.FullName)
                    & FileAttributes.Hidden)
                    != FileAttributes.Hidden & fi.Extension != ".gz")
                {
                    using (FileStream outFile =
                                File.Create(fi.FullName + ".gz"))
                    {
                        using (GZipStream Compress =
                            new GZipStream(outFile,
                            CompressionMode.Compress))
                        {

                            inFile.CopyTo(Compress);

                            Console.WriteLine("Compressed {0} from {1} to {2} bytes.",
                                fi.Name, fi.Length.ToString(), outFile.Length.ToString());
                        }

                    }

                }
            }
        }
    }
}
