/* Создайте класс AbstractHandler.  
 * В теле класса создать методы void Open(), void Create(), void Chenge(), void Delete().  
 * Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.  
 * Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, удаления определенного формата документа. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace abstractions_task1
{
    abstract class AbstractHandler
    {
        public virtual void Open(string FullPath) { }
        public virtual void Create(string FullPath) { }
        public virtual void Change(string FullPath) { }
        public virtual void Delete(string FullPath) { }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open(string FullPath)
        {
            using (StreamReader sr = File.OpenText(FullPath))
            {
                Console.WriteLine("Text from txt file:");
                string inner = "";
                while ((inner = sr.ReadLine()) != null)
                {
                    Console.WriteLine(inner);
                }
            }
        }
        public override void Create(string FullPath)
        {
            using (FileStream fs = File.Create(FullPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This .txt file created by C# script");
                fs.Write(info, 0, info.Length);
                Console.WriteLine("Done!");
            }
        }
        public override void Change(string FullPath)
        {
            Console.WriteLine("Type some new text for text file:");
            using (StreamWriter sw = File.AppendText(FullPath))
            {
                string extraText = Console.ReadLine();
                sw.WriteLine("\n" + extraText);
                Console.WriteLine("Done!");
            }
        }
        public override void Delete(string FullPath)
        {
            File.Delete(FullPath);
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open(string FullPath)
        {
            using (StreamReader sr = File.OpenText(FullPath))
            {
                Console.WriteLine("Text from .doc file:");
                string inner = "";
                while ((inner = sr.ReadLine()) != null)
                {
                    Console.WriteLine(inner);
                }
            }
        }
        public override void Create(string FullPath)
        {
            using (FileStream fs = File.Create(FullPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This .doc file created by C# script");
                fs.Write(info, 0, info.Length);
                Console.WriteLine("Done!");
            }
        }
        public override void Change(string FullPath)
        {
            Console.WriteLine("Type some new text for .doc file:");
            using (StreamWriter sw = File.AppendText(FullPath))
            {
                string extraText = Console.ReadLine();
                sw.WriteLine("\n" + extraText);
                Console.WriteLine("Done!");
            }
        }
        public override void Delete(string FullPath)
        {
            File.Delete(FullPath);
        }
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open(string FullPath)
        {
            using (StreamReader sr = File.OpenText(FullPath))
            {
                Console.WriteLine("Text from .xml file:");
                string inner = "";
                while ((inner = sr.ReadLine()) != null)
                {
                    Console.WriteLine(inner);
                }
            }
        }
        public override void Create(string FullPath)
        {
            using (FileStream fs = File.Create(FullPath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes("This .xml file created by C# script");
                fs.Write(info, 0, info.Length);
                Console.WriteLine("Done!");
            }
        }
        public override void Change(string FullPath)
        {
            Console.WriteLine("Type some new text for .xml file:");
            using (StreamWriter sw = File.AppendText(FullPath))
            {
                string extraText = Console.ReadLine();
                sw.WriteLine("\n" + extraText);
                Console.WriteLine("Done!");
            }
        }
        public override void Delete(string FullPath)
        {
            File.Delete(FullPath);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string FullPath;
            Console.Write("Enter path to the file (XML, DOC or TXT): ");
            FullPath = Console.ReadLine();
            switch(Path.GetExtension(FullPath))
            {
                case (".txt"):
                    TXTHandler TXT = new TXTHandler();
                    if(!File.Exists(FullPath))
                    {
                        TXT.Create(FullPath);
                    } else
                    {
                        TXT.Open(FullPath);
                    }
                    TXT.Change(FullPath);
                    Console.Write("Do you want to delete this file?: ");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        TXT.Delete(FullPath);
                    }
                    else break;

                    break;
                case (".doc"):
                    DOCHandler DOC = new DOCHandler();
                    if (!File.Exists(FullPath))
                    {
                        DOC.Create(FullPath);
                    }
                    else
                    {
                        DOC.Open(FullPath);
                    }
                    DOC.Change(FullPath);
                    Console.Write("Do you want to delete this file?: ");
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        DOC.Delete(FullPath);
                    }
                    else break;
                    break;
                case (".xml"):
                    XMLHandler XML = new XMLHandler();
                    if (!File.Exists(FullPath))
                    {
                        XML.Create(FullPath);
                    }
                    else
                    {
                        XML.Open(FullPath);
                    }
                    XML.Change(FullPath);
                    Console.Write("Do you want to delete this file?: ");
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        XML.Delete(FullPath);
                    }
                    else break;
                    break;
                default:
                    Console.WriteLine("Incorrect file type (not txt/doc/xml)!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
