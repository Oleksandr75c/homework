using Homework7;
using System;

public class Teacher : Person
{

    public string city { get; set; }

    internal List<Student> students { get; set; } = new List<Student>();
    internal List<Courses> courses { get; set; } = new List<Courses>();
    public const string NOT_ASSIGNED = "not assigned";

    public Teacher(string firstName, string lastName, int age, string city)    // konstruktor 1
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.city = city;
    }

    public Teacher(string firstName, string lastName, int age)    // konstruktor
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.city = "unknown";
    }

    public override void AlternativePrint()
    {
        string strTmp = "";
        //Console.WriteLine("\n**** object Teacher ****");
        Console.WriteLine($"\n {firstName} {lastName} is {age} and lives in {city} city.");

        foreach (Student student in students) strTmp += student.firstName + " " + student.lastName + ", ";
        if (strTmp != "")
            Console.WriteLine($"List of students ({GetNumberStudents()}): { strTmp.Trim(',').Trim()}.");
        else
            Console.WriteLine("No students.");
        strTmp = "";
        foreach (Courses cource in courses) strTmp += cource.name + ", ";
        if (strTmp != "")
            Console.WriteLine($"List of cources ({GetNumberCources()}): {strTmp.Trim().Trim(',')}.");
        else
            Console.WriteLine("No cources.");
    }
    public int GetNumberStudents()
    {
        return students.Count;
    }
    public int GetNumberCources()
    {
        return courses.Count;
    }
    public void AddCourse(ref Courses course1)      // Add course to current teacher
    {
        bool a;
        this.courses.Add(course1);
        course1.teacherName = this.firstName + " " + this.lastName;

        // add students from course student list to teacher students list
        foreach (Student student1 in course1.students)
        {   
            a=true;    // student ubsent in list
            foreach (Student student2 in this.students)
                if (student1 == student2) // a student from the list of courses is already present in the teacher's student list
                {
                    a = false;
                    break;
                }
            if (a) this.students.Add(student1);
        }
    }
    public void AddStudent(Student student1)
    {
        bool a = true;
        foreach(Student student2 in this.students)
            if (student1 == student2)
                { a = false; break; }
        if(a)  this.students.Add(student1);
    }
    public void LeaveCourse(ref Courses course0, List<Student> ls)
    {   bool a = true;
        foreach (Student student2 in ls)
        {
            a = true;
            foreach (Student student1 in this.students)
            {   
                if (student1 == student2)   // find student from Student List in  teacher's student list
                {
                    foreach (Courses course1 in student2.cources) 
                    { if ((course1 != course0) && (course1.teacherName == course0.teacherName)) 
                        { // this student has another course in this teacher
                            a = false;
                            break;   
                        }
                    }
                }
                if (!a)  break;
            }
            if (a) // this student hasn't another course in this ticher and can be removed
                this.students.Remove(student2);
        }
        course0.teacherName = NOT_ASSIGNED;
        this.courses.Remove(course0); 
    }
    public void Print()
    {
        Console.WriteLine("\n*** object Teacher ***");
        Console.WriteLine($"Name: {firstName} {lastName} ");
        Console.WriteLine($"City: {city}, Age: {age}");
    }
}