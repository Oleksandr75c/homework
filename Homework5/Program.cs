using Homework5;
using System.ComponentModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 
         Courses course1 = new Courses("C#1","Kristina","C# level1");
         Courses course2 = new Courses("C#2", "Kristina", "C# level2");
         Student stud1 = new Student("Oleksander", "Movchan", 47, "Zhitomyr");
         Student stud2 = new Student("Vasya", "Pupkin", 35, "Kiev");

            course1.Print();
            course2.Print();
            stud1.Print();
            stud2.Print();

            Console.WriteLine("\n*********** Add students to courses **********");
            course1.AddOneStudents(ref stud1);
            stud2.AddCource(ref course1);
            stud2.AddCource(ref course2);

            course1.Print();
            course2.Print();
            stud1.Print();
            stud2.Print();

            Console.WriteLine("\n************ del student from courses **********");
            stud2.DelCource(ref course1);

            course1.Print();
            course2.Print();
            stud1.Print();
            stud2.Print();

        }
    }
}