using System;

    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public Person() { }                             // konstruktor 0
        public Person(string name, string lastName)     // konstruktor1
        { 
            this.firstName = name;
            this.lastName = lastName;
        }
        public Person(string name, string lastName, int age)     // konstruktor2
        {
            this.firstName = name;
            this.lastName = lastName;
            this.age = age;
        }
        public virtual void AlternativePrint() 
        {
            Console.WriteLine("\n*** object Person ***");
            Console.WriteLine($" {firstName} {lastName} is {age}");
        }
    }
