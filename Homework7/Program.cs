using System.ComponentModel;

namespace Homework7
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            const string NOT_ASSIGNED = "not assigned";

            List<Teacher> lTeachers = new List<Teacher>();
            List<Student> lStudents = new List<Student>();
            List<Courses> lCourses = new List<Courses>();

            lTeachers.Add(new Teacher("Krystina", "Hurieieva", 25));
            lTeachers.Add(new Teacher("Mahatma", "Gandy", 78, "Porbandar"));

            lStudents.Add(new Student("Oleksander", "Oleksandrov", 27, "Zhitomyr"));
            lStudents.Add(new Student("Ivan", "Ivanov", 26, "Kiev"));
            lStudents.Add(new Student("Petro", "Petrov", 25, "Odessa"));
            lStudents.Add(new Student("Sidor", "Sidorov", 25, "Rivne"));
            lStudents.Add(new Student("Vasily", "Vasilyev", 25, "Dnipro"));

            lCourses.Add(new Courses("C# part1",20));
            lCourses.Add(new Courses("C# part2", 30));
            lCourses.Add(new Courses("History", 40));
            lCourses.Add(new Courses("Philosophy", 50));

            Courses c;
            Teacher t;
            Student s;
            var rand = new Random();
            int i, j;



        // Print empty object
            Console.WriteLine("\n***** objects Teacher *****");
            foreach (Teacher teacher in lTeachers) teacher.AlternativePrint();

            Console.WriteLine("\n***** objects Student *****");
            foreach (Student student in lStudents) student.AlternativePrint();

            Console.WriteLine("\n***** objects Course *****");
            foreach ( Courses course in lCourses) course.Print();


            // Assine students and teachers to cources
            c = lCourses[0];  lTeachers[0].AddCourse(ref c); lCourses[0] = c;
            t = lTeachers[0]; lCourses[1].AddTeacher(ref t); lTeachers[0]= t;

            foreach (Student student in lStudents) // Random assigment students to course with using student.addcourse()
            {
                i = rand.Next(0, lCourses.Count-1);
                c = lCourses[i];
                student.AddCourse(ref c);
                lCourses[i] = c;
            }

            foreach (Courses course1 in lCourses) // Random assigment students to course with using course.addstudent()
            {
                i = rand.Next(0, lStudents.Count-1);
                s = lStudents[i];
                course1.AddStudent(ref s);
                lStudents[i] = s;

                if (course1.teacherName != NOT_ASSIGNED)
                {  // find teacher and add student
                     foreach (Teacher teacher1 in lTeachers)
                        if ((teacher1.firstName + " " +teacher1.lastName) == course1.teacherName) teacher1.AddStudent(s);
                }
            }

            c = lCourses[2];  lTeachers[1].AddCourse(ref c); lCourses[2] = c;
            t = lTeachers[1]; lCourses[3].AddTeacher(ref t); lTeachers[1] = t;


            // Print full object
            Console.WriteLine("\n************************ AFTER ASSINE *****************************");
            Console.WriteLine("\n***** objects Teacher *****");
            foreach (Teacher teacher in lTeachers) teacher.AlternativePrint();

            Console.WriteLine("\n***** objects Student *****");
            foreach (Student student in lStudents) student.AlternativePrint();

            Console.WriteLine("\n***** objects Course *****");
            foreach (Courses course in lCourses) course.Print();

            // Teacher leave course
            Console.WriteLine($"\nTeacher {lTeachers[1].firstName} {lTeachers[1].lastName} has left course {lCourses[3].name}");
            c = lCourses[3]; lTeachers[1].LeaveCourse(ref c, lStudents);

            //Finish course random - 
            i = rand.Next(0, lCourses.Count - 1);
            Console.WriteLine($" Course {lCourses[i].name} was finished");
            lCourses[i].FinishCourse(ref lStudents, ref lTeachers);


            //student expulsion random
            i = rand.Next(0, lStudents.Count - 1);
            if (lStudents[i].cources.Count > 0)
            {
                j = rand.Next(0, lStudents[i].cources.Count - 1);
                Console.WriteLine($"Student {lStudents[i].firstName} {lStudents[i].lastName} has finished course {lStudents[i].cources[j].name}");
                lStudents[i].RemoveCourse(lStudents[i].cources[j], ref lCourses, ref lTeachers);
            }

            Console.WriteLine("\n************************ AFTER Remove *****************************");
            Console.WriteLine("\n***** objects Teacher *****");
            foreach (Teacher teacher in lTeachers) teacher.AlternativePrint();

            Console.WriteLine("\n***** objects Student *****");
            foreach (Student student in lStudents) student.AlternativePrint();

            Console.WriteLine("\n***** objects Course *****");
            foreach (Courses course in lCourses) course.Print();
        }

    }
}