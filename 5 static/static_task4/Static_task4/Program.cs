//Создать собственные реализации методов Substring(int,int), IndexOf(string), Replace(string,string) 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task4
{
    static class CustomString
    {
        public static string CustomSubstring(this string s1, int startindex, int length)
        {
            string sub = "";
            for(int i = startindex; i <= length; i++)
            {
                sub += s1[i];
            }
            return sub;
        }
        public static int CustomIndexOf(this string s1, string keyword)
        {
            int res = 0;
            for (int i = 0; i <= s1.Length; i++)
            {
                if(s1[i] == keyword[0])
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        private static bool IsSub(string src, int i, string str)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] != src[i + j]) return false;
            }
            return true;
        }

        public static string CustomReplace(this string Str1, string Str2, string Str3)
        {
            var stroka = new StringBuilder();
            for (int i = 0; i < Str1.Length; i++)
            {
                if (IsSub(Str1, i, Str2))
                {
                    stroka.Append(Str3);
                    i += Str2.Length - 1;
                }
                else stroka.Append(Str1[i]);
            }
            return stroka.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string sub = s1.CustomSubstring(1, 2);
            Console.WriteLine(sub);
            Console.WriteLine(s1.CustomIndexOf("el"));
            Console.WriteLine(s1.CustomReplace("el", "at"));
            Console.ReadKey();
        }
    }
}
