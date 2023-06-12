

namespace Homework7
{
    public class Courses
    {
        public string name { get; set; }
        public string teacherName { get; set; }
        public int courseDuration { get; set; }  
        public int totalStudents { get; set;}
        internal List<Student> students { get; set; } = new List<Student>();
        public const string NOT_ASSIGNED = "not assigned";


        public  Courses(string name, string teacherName, int courseDuration)    // konstruktor
        {
            this.name = name;
            this.teacherName = teacherName;
            this.courseDuration = courseDuration;
            this.totalStudents = 0;

        }
        public Courses(string name, int courseDuration)    // konstruktor2
        {
            this.name = name;
            this.courseDuration = courseDuration;
            this.teacherName = NOT_ASSIGNED;
            this.totalStudents = 0;

        }
        public void Print()
        {
            string strTmp = "";
            //Console.WriteLine("\n**** object Courses ****");
            Console.WriteLine($"\nCource name: {name}, {courseDuration} hours");
            Console.WriteLine($"Teacher name: {teacherName}");
            foreach (Student student in students) strTmp += student.firstName + " " + student.lastName + ", ";
            if (strTmp != "")
                Console.WriteLine($"Total students: {GetNumberStudents()}: {strTmp.Trim(',').Trim()}.");
            else 
                Console.WriteLine("Students are not assigned.");
        }
        public int GetNumberStudents()
        { 
            return students.Count;
        }
        public void AddTeacher(ref Teacher teacher)     // Add Teacher to course
        {
            bool a;
            this.teacherName = teacher.firstName + " " + teacher.lastName;
            teacher.courses.Add(this);
            // add students from course student list to teacher students list
            foreach (Student student1 in this.students)
            {
                a = true;    // student ubsent in list
                foreach (Student student2 in teacher.students)
                    if (student1 == student2) // a student from the list of courses is already present in the teacher's student list
                    {
                        a = false;
                        break;
                    }
                if (a) teacher.students.Add(student1);
            }
        }
        public void AddStudent(ref Student stud1)     // Add Student to course
        {
            bool a = true;
            // add student to courses object student list
            foreach (Student stud in this.students)     // verification or student already present
                if (stud == stud1)                      // student already present
                {
                    a = false; 
                    break;
                }
            if (a)   // if not present, add to list
            {
                students.Add(stud1);
                stud1.cources.Add(this);
                this.totalStudents = students.Count;
            }
        }
        public void FinishCourse(ref List<Student> ls, ref List<Teacher> lt)
        {
            foreach (Teacher teacher1 in lt)
                if ((teacher1.firstName + " " + teacher1.lastName) == this.teacherName)
                {
                    Courses co = this;
                    teacher1.LeaveCourse(ref co, ls);  //remove teacher from course list
                }
            foreach (Student student1 in ls)
                foreach (Courses course1 in student1.cources)
                    if (course1 == this)
                    {
                        student1.cources.Remove(this); // remove course from student list
                        break;
                    }

        }
    }
}
