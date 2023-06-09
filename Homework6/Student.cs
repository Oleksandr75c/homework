using Homework6;
using System;

public class Student : Person
{

    public string city { get; set; } = "unknown";
    internal Courses[] cources { get; set; } = new Courses[20];
     public int counterCources { get; set; } = 0;
   

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
        // base.AlternativePrint();
        Console.WriteLine("\n*** object Student ***");
        Console.WriteLine($" {firstName} {lastName} is {age} and lives in {city} city.");
    }
    public void Print()
    {
        Console.WriteLine("\n*** object Student ***");
        Console.WriteLine($"Name: {firstName} {lastName} ");
        Console.WriteLine($"City: {city}, Age: {age}");
        Console.WriteLine("Active courses:");
        for (int i = 0; i < this.counterCources;i++)
        Console.WriteLine($" {1+i}. {this.cources[i].name}");
    }

    public void AddCource(ref Courses co)
    {
        co.totalStudents++;
        this.cources[counterCources] = co;
        this.counterCources++; 
    }

    public bool DelCource(ref Courses co)
    {

        for(int i=0; i< this.counterCources; i++)
            if (co.name == this.cources[i].name) 
            {
                this.cources[i] = this.cources[this.counterCources - 1];
                co.totalStudents--;
                this.counterCources--;
                return true;
            }
        return false;
    }

}
