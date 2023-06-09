using Homework6;
using System;

public class Teacher : Person
{

    public string city { get; set; }
    internal Courses[] cources { get; set; } = new Courses[20];
    public int counterCources { get; set; } = 0;


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
        // base.AlternativePrint();
        Console.WriteLine("\n*** object Teacher ***");
        Console.WriteLine($" {firstName} {lastName} is {age} and lives in {city} city.");
    }
    public void Print()
    {
        Console.WriteLine("\n*** object Teacher ***");
        Console.WriteLine($"Name: {firstName} {lastName} ");
        Console.WriteLine($"City: {city}, Age: {age}");
    }
}