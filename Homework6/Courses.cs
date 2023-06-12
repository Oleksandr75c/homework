using System;
public class Courses
    {
        public string name { get; set; }
        public string teacherName { get; set; }
        public string courseDuration { get; set;}
        public int totalStudents { get; set;}


         public  Courses(string name, string teacherName, string courseDuration)    // konstruktor
        {
            this.name = name;
            this.teacherName = teacherName;
            this.courseDuration = courseDuration;
            this.totalStudents = 0;

        }
        public void Print()
        {
            Console.WriteLine("\n*** object Courses ***");
            Console.WriteLine($"Cource name: {name}");
            Console.WriteLine($"Teacher name: {teacherName}");
            Console.WriteLine($"Description: {courseDuration}");
            Console.WriteLine($"Total studenrs: {totalStudents}");
        }

        public void AddOneStudents(ref Student st) 
        { 
            st.cources[st.counterCources] = this;
            this.totalStudents++;
            st.counterCources++;
        }
}