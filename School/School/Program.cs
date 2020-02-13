using System;
using System.Collections.Generic;
using System.Collections;


namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ramya = new Student("Ramya");
            Student krish = new Student("Krish");
            Course cSharp = new Course("cSharp", "Scott");
            Course java = new Course("Java", "James");

            List<string> students = new List<string>();
            students.Add(ramya.Name);
            
            Course addJava = new Course("Java", "James", students);

            Console.WriteLine("Java Students: ");
            foreach (string name in students)
                Console.WriteLine(name);
            
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

    }
    public class Course
    {
        private int noOfStudents= 0;
        public const int MAXSTUDENTS = 30;
        public Student students;
        public string CourseName { get; set; }
        public string Teacher { get; set; }
        public List<string> Students { get; set; }
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
        public Course(string courseName, string teacher, List<string> studentsList)
        {
            
           /* for(int i = 0; i < studentsList.Count; i++)
            {
                
            }*/
            
            NumberOfSeats = noOfStudents++;
            CourseName = courseName;
            Teacher = teacher;
            Students = studentsList;
        }
    }
}
