using System;
using System.Collections.Generic;
using System.Collections;


namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Student ramya = new Student("Ramya");
            Student krish = new Student("Krish");
            Course cSharp = new Course("cSharp", "Scott");
            Course java = new Course("Java", "James");

            List<string> students = new List<string>();
            students.Add(ramya.Name);
            
            Course addJava = new Course("Java", "James", students);

            Console.WriteLine("Java Students: ");
            foreach (string name in students)
                Console.WriteLine(name);*/
            
            Console.ReadLine();
        }
    }
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; internal set; }
        public int StudentId { get;  set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        public Student(string name, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = nextStudentId++;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }
        public Student(string name) : this(name, 0, 0) { }
        public void AddGrade(int courseCredits,double grade)
        {
            double qualityScore = Gpa*NumberOfCredits;
            NumberOfCredits += courseCredits;
            Gpa = (qualityScore + (courseCredits * grade)) / NumberOfCredits;
        }
        public string GetGradeLevel()
        {
            if (NumberOfCredits > 89)
                return "senior";
            else if (NumberOfCredits > 59)
                return "junior";
            else if (NumberOfCredits > 29)
                return "sophomore";
            else
                return "freshman";
            
        }
        public override string ToString()
        {
            return Name + "(Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }
        public override bool Equals(Object o)
        {
            if (o == this)
                return true;
            if (o == null || o.GetType()!=GetType())
                return false;
         
            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }
        public override int GetHashCode()
        {
            return StudentId;
        }
    }
    public class Course
    {
        private int noOfStudents= 0;
        public const int MAXSTUDENTS = 30;
        
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public List<Student> Students  { get; set; } = new List<Student>();
        public int NumberOfSeats
        {
            get
            {
                return noOfStudents;
            }
            set
            {
                if (noOfStudents > MAXSTUDENTS)
                    throw new ArgumentException("There are no available seats");
                noOfStudents = value;
            }
        }
        public Course(string courseName,string teacher)
        {
            NumberOfSeats = noOfStudents++;
            CourseName = courseName;
            Teacher = teacher;
        }
        public Course(string courseName, string teacher, List<Student> studentsList)
        {
                
            
            NumberOfSeats = noOfStudents++;
            CourseName = courseName;
            Teacher = teacher;
            Students = studentsList;
        }
    }
}
