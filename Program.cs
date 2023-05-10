using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Parkoding_Uke_2
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kurs { get; set; }


        public Student() { }

        public Student(string name, int age, string kurs)
        {
            Name = name;
            Age = age;
            Kurs = kurs;
        }

        public void IntroduceSelf()
        {
            Console.WriteLine($"Hei jeg heter {Name} og jeg er {Age} år. Mitt passion er {Kurs}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var student = new { Navn = "Heibert", Age = 42, Kurs = "Radiobilkjøring" };
            var student1 = new Student { Name = "Hans Petter", Age = 92, Kurs = "Strikking" };
            var student2 = new Student("Snorre", 32, "Fiskeriminister");
            var student3 = new Student();
            student3.Name = "Fabian";
            student3.Age = 10;
            student3.Kurs = "Strikking";
            var studenter = new List<Student>() { student1, student2, student3 };

            string kurs = Console.ReadLine();
            foreach (var student in studenter)
            {
                if (student.Kurs == kurs) student.IntroduceSelf();
                //if (student.Kurs == "Strikking") student.IntroduceSelf();
            }

            Console.ReadLine();

        }
    }
}