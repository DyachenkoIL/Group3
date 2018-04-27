/*Задание 3
Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change.
В классе Program создайте два метода:
- static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass
значение «изменено».
- static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct
значение «изменено».
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры
структуры и класса. Измените, значения полей экземпляров на «не изменено», а затем вызовите методы
ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные
результаты.
Miroshnichenko Denis*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures_task3
{
    /*Класс является ссылочным типом. 
     * Когда вы создаете объект класса и сохраняете его в переменную, эта переменная содержит только ссылку на память объекта. 
     * Если ссылка на объект сохраняется в новую переменную, эта переменная также ссылается на исходный объект. 
     * Изменения, внесенные через одну переменную, отражаются и в другой переменной, поскольку обе они ссылаются на одни и те же данные. */
    class MyClass
    {
        public string change;
        public MyClass() //Классы могу содержать явные конструкторы без параметров, поля можно не инициализировать
        {
            change = "не изменено";
        }
    }
    /*Структура (struct) является типом значения. 
     * При создании структуры переменная, которой присвоена структура, содержит фактические данные этой структуры. 
     * Если структура присваивается новой переменной, все данные копируются. Таким образом, новая переменная и исходная переменная содержат две отдельные копии одинаковых данных. 
     * Изменения, внесенные в одну копию, не влияют на другую. */
    struct MyStruct
    {
        public string change;
        public MyStruct(string s_in) // Структуры не могут содержать явных конструкторов без параметров, все неинициализированные поля должны быть инициализированы
        {
            this.change = s_in;
        }
        public void StructTaker(MyStruct myStruct)
        {
            this.change = "изменено";
        }
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        } // сработает, так как экземпляр класса хранится в куче, и ссылаясь на клас можно изменять его поля
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        } // невозможно изменить значения полей уже созданного экземпляра стурктуры, можно заменить всю структуру, либо упаковать структуру и изменить значение поля объекта в куче
        static void Main(string[] args)
        {
            string test = "не изменено";
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct(test);
            Console.Write(myStruct.change + "\n" + myClass.change);
            ClassTaker(myClass);
            StructTaker(myStruct);
            Console.Write("\n" + myStruct.change + "\n" + myClass.change);
            Console.ReadKey();
        }
    }
}
