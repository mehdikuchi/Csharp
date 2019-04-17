using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating 3 students:
            Student st1 = new Student("john", "nicole");
            Student st2 = new Student("barbara", "fry");
            Student st3 = new Student("Smith", "Jones");
            //Adding 5 gradse for each students using the Push method of the Stack:
            st1.Grades.Push(19);
            st1.Grades.Push(20);
            st1.Grades.Push(10.90);
            st1.Grades.Push(10);
            st1.Grades.Push(15.75);
            st2.Grades.Push(18);
            st2.Grades.Push(19);
            st2.Grades.Push(17);
            st2.Grades.Push(16);
            st2.Grades.Push(12);
            st3.Grades.Push(20);
            st3.Grades.Push(16);
            st3.Grades.Push(17);
            st3.Grades.Push(15);
            st3.Grades.Push(10);
            // Instantiating a course with the specified name:
            Course cs1 = new Course("Programming with C#");
            //Adding students to the object course using the List Add method:
            cs1.Students.Add(st1);
            cs1.Students.Add(st2);
            cs1.Students.Add(st3);
            //Instantiating 3 teacher objects:
            Teacher TA1 = new Teacher("Smith");
            Teacher TA2 = new Teacher("katrine");
            Teacher TA3 = new Teacher("Katrine", "Smith");
            //Adding teachers to the object course:
            cs1.Ta[0] = TA1;
            cs1.Ta[1] = TA2;
            cs1.Ta[2] = TA3;
            //Instantiating a Bachelor degree
            Degree dg = new Degree("Bachelor of Science");
            //Adding the instantiated course to the degree
            dg.Cs = cs1;
            //Instantiating a university program called IT:
            UProgram UP = new UProgram("Information Technology");
            //Adding the instantiated degree to the university program:
            UP.Deg = dg;
            //Outputting the requested data using the Console.WriteLine method:
            Console.WriteLine("The program name is {0} and it contains the {1} degree.", UP.Name, dg.Name);
            Console.WriteLine("The {0} degree contains the course {1}.", dg.Name, cs1.Name);
            Console.WriteLine("The number of students enrolled in the {0} course: {1}.", cs1.Name, Student.GetNumOfStudent());
            //Printing the name of the students currently enrolled in the course using the ListStudents method:
            cs1.ListStudents();
            Console.ReadKey();
        }
    }
    // Defining the base class person:
    public class Person
    {
        //using automatic properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Addline1 { get; set; }
        public string Addline2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Zip { get; set; }
        // using defined properties:
        private string state;
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public Person(String name = "Blank",
            String surname = "Blank",
            String birthday = "Blank",
            String addline1 = "Blank",
            String addline2 = "Blank",
            int zip = 0,
            String city = "Blank",
            String state = "Blank",
            String country = "Blank")
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Addline1 = addline1;
            this.Addline2 = addline2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Country = country;
        }
    }
    // Defining Teacher class based on person class:
    public class Teacher : Person
    {
        // Properties applly to teachers only:
        public string Rank { get; set; }
        public void GradeTest()
        {
            // Functionality is not provided in the instructions.
            throw new NotImplementedException();
        }
        public Teacher(String name = "Blank",
            String surname = "Blank",
            String birthday = "Blank",
            String addline1 = "Blank",
            String addline2 = "Blank",
            int zip = 0,
            String city = "Blank",
            String state = "Blank",
            String country = "Blank",
            string rank = "Assosiate professor")
            : base(name, surname)
        {
            this.Rank = rank;
        }
    }
    public class Student : Person
    {
        //Student specefic properties:
        public string TypeOfStudy { get; set; }
        // The following field holds the number of student objects created so far.
        private static int NumOfStudents = 0;
        //Adding a generic stack object of doubles called grades to hold students' scores: 
        private Stack<double> grades = new Stack<double>();
        public Stack<double> Grades
        {
            get
            {
                return grades;
            }
            set
            {
                grades = value;
            }
        }
        public Student(String name = "Blank",
            String surname = "Blank",
            String birthday = "Blank",
            String addline1 = "Blank",
            String addline2 = "Blank",
            int zip = 0,
            String city = "Blank",
            String state = "Blank",
            String country = "Blank",
            string type = "Full Time")
            : base(name, surname)
        {
            this.TypeOfStudy = type;
            NumOfStudents += 1;
        }
        public static int GetNumOfStudent()
        {
            return NumOfStudents;
        }
        public void TakeTest()
        {
            //Functionality for this code is not provided in the instructions
            throw new NotImplementedException();
        }
    }

    public class Course
    {
        public string Name { get; set; }
        //Create a list of type Student to hold students:
        private List<Student> students=new List<Student>();
        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }
        private Teacher[] ta = new Teacher[3];      //The array to hold 3 teachers 
        public Teacher[] Ta                         // The property implementation
        {
            get
            {
                return ta;
            }
            set
            {
                ta = value;
            }
        }
        public Course(string name)
        {
            this.Name = name;
        }
        //Creating ListStudents method which lists the students' name and surname using the foreach loop
        public void ListStudents()
        {
            int counter = 1;
            foreach (Student st in students) 
            {
                Console.WriteLine("Student Number {0}: Name: {1} Surname: {2}", counter, st.Name, st.Surname);
                counter++;
            }
        }
    }

    public class Degree
    {
        public string Name { get; set; }
        public Course Cs { get; set; } //This property (Cs) will hold the course 
        public Degree(String name)
        {
            this.Name = name;
        }
    }

    public class UProgram
    {
        public string Name { get; set; }
        public Degree Deg { get; set; } //This property (Deg) will hold the degree class 
        public UProgram(string name)
        {
            this.Name = name;
        }

    }
}
