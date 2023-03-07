
using Read;
using Stud;

namespace Stud
{
    public class Student
    {

        public string Fio;
        public string group;
        private int age;

        public Student(string Fio, string group, int age)
        {
            this.Fio = Fio;
            this.group = group;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine("фамилия" + Fio + "группа" + group + "возраст" + age);
        }
    }
}
namespace Read
{
    public class Reader
    {
        private string fio;
        public int numberReadTick;
        public string faculty;
        private int age;
        public Reader(string fio, int numberReadTick, string faculty,int age)
        {
            this.fio = fio;
            this.numberReadTick = numberReadTick;
            this.faculty = faculty;   
            this.age = age;
        }

        public void takeBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void takeBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }

        public void returnBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void returnBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }
    }
}
namespace laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Филетина А. С.","20ИТ17", 20),
                new Student("Ролкина Ж. Е.", "20ИТ17", 21),
                new Student("Колбаскина С. С.","20ИТ17", 19)
            };

            Reader[] libraryUsers =
            {
                new Reader("Филетина А. С.",8395883 , "Информатика", 20),
                new Reader("Ролкина Ж. Е.",63754845 , "Моделирование", 21),
                new Reader("Колбаскина С. С.", 23756347, "Математика", 19)
            };
        }
    }
}