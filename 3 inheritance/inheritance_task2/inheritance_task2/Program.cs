/*Создать класс, представляющий учебный класс ClassRoom.  
 * Создайте класс ученик Pupil. 
 * В теле класса создайте методы void Study(), void Read(), void Write(), void Relax().  
 * Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика.  
 * Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников.  
 * Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента.  
 * Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_task2
{
    class ClassRoom
    {
        Pupil[] arrPupil;
        public ClassRoom(params Pupil[] p)
        {
            arrPupil = p;
        }
        public void StudyInfo()
        {
            foreach (Pupil item in arrPupil)
            {
                item.Study();
            }
        }
        public void ReadInfo()
        {
            foreach (Pupil item in arrPupil)
            {
                item.Read();
            }
        }
        public void WriteInfo()
        {
            foreach (Pupil item in arrPupil)
            {
                item.Write();
            }
        }
        public void RelaxInfo()
        {
            foreach (Pupil item in arrPupil)
            {
                item.Relax();
            }
        }
    }
    class Pupil
    {
        public virtual void Study() { }
        public virtual void Read() { }
        public virtual void Write() { }
        public virtual void Relax() { }
    }
    class ExellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: 10 - Exellent");
        }
        public override void Read()
        {
            Console.WriteLine("Read: 10 - Exellent");
        }
        public override void Write()
        {
            Console.WriteLine("Write: 10 - Exellent");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: 8 - Exellent");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: 8 - Good");
        }
        public override void Read()
        {
            Console.WriteLine("Read: 7 - Good");
        }
        public override void Write()
        {
            Console.WriteLine("Write: 7 - Good");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: 7 - Good");
        }
    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study: 3 - Bad");
        }
        public override void Read()
        {
            Console.WriteLine("Read: 2 - Bad");
        }
        public override void Write()
        {
            Console.WriteLine("Write: 3 - Bad");
        }
        public override void Relax()
        {
            Console.WriteLine("Relax: 9 - Bad");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom CR1 = new ClassRoom(new BadPupil(), new GoodPupil(), new BadPupil(), new ExellentPupil(), new GoodPupil());

            CR1.StudyInfo();
            CR1.ReadInfo();
            CR1.WriteInfo();
            CR1.RelaxInfo();

            Console.ReadKey();
        }
    }
}
