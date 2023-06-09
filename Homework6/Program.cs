using Homework6;
using System.ComponentModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        { 

         Person person1 = new Person("Vasya", "Pupkin", 35);
         Teacher teacher1 = new Teacher("Krystina", "Hurieieva", 25);
         Student student1 = new Student("Oleksander", "Movchan", 47, "Zhitomyr");

            person1.AlternativePrint();
            teacher1.AlternativePrint();
            student1.AlternativePrint();


            /* 
             Courses course1 = new Courses("C#1","Krystina","C# level1");
             Courses course2 = new Courses("C#2", "Krystina", "C# level2");
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
            */
        }
    }
}