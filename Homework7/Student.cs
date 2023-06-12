using Homework7;
using System;

public class Student : Person
{

    public string city { get; set; } = "unknown";
   // internal Courses[] cources { get; set; } = new Courses[20];
  //   public int counterCources { get; set; } = 0;
    internal List<Courses> cources { get; set; } = new List<Courses>();


    public Student(string firstName, string lastName, int age)    // konstruktor 1
    { 
        this.firstName = firstName; 
        this.lastName = lastName;
        this.age = age;
	}
    public Student(string firstName, string lastName, int age, string city)    // konstruktor 2
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.city = city;
    }

    public override void AlternativePrint()
    {
        string strTmp = "";
        //Console.WriteLine("\n*** object Student ***");
        Console.WriteLine($"\n {firstName} {lastName} is {age} and lives in {city} city.");
        Console.WriteLine($"List of cources ({GetNumberCources()}):");
        foreach (Courses cource in cources) strTmp += cource.name + ", ";
        if (strTmp != "")
            Console.WriteLine(strTmp.Trim().Trim(',') + ".");
        else
            Console.WriteLine("none");
    }
    public int GetNumberCources()
    {
        return cources.Count;
    }
    public void AddCourse(ref Courses co)
    {
        bool a = true;
        foreach (Courses cource in cources)
            if(cource==co)      // student already present on this course
            {
                a = false;
                break;
            }
        if (a)
        {
            this.cources.Add(co);
            co.students.Add(this);
            co.totalStudents=co.students.Count;
        }
    }
    public void RemoveCourse(Courses course0, ref List<Courses> lc, ref List<Teacher> lt)
    {   bool a = true;
        this.cources.Remove(course0);
        foreach (Courses course1 in lc) // remove student from Course's student list
            if (course1 == course0)
                foreach (Student student1 in course1.students)
                    if(student1==this)
                    {
                        course1.students.Remove(this); 
                        break;
                    }
        foreach (Teacher teacher1 in lt) // remove student from Teacher's student list
            foreach (Student student1 in teacher1.students)
                if (student1 == this)
                {
                    foreach (Courses cource1 in teacher1.courses)
                        if (cource1 != course0)
                        {
                            a = false;
                            break;
                        }
                    if (a)
                    {
                        teacher1.students.Remove(this);
                        break;
                    }
                }
    }
    public void Print()
    {
        Console.WriteLine("\n*** object Student ***");
        Console.WriteLine($"Name: {firstName} {lastName} ");
        Console.WriteLine($"City: {city}, Age: {age}");
       // Console.WriteLine("Active courses:");
       //for (int i = 0; i < this.counterCources;i++)
       //Console.WriteLine($" {1+i}. {this.cources[i].name}");
    }

}
