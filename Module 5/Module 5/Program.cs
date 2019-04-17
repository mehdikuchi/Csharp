using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating 3 students:
            Student st1 = new Student("john");
            Student st2 = new Student("barbara");
            Student st3 = new Student();
            // Instantiating a course with the specified name:
            Course cs1 = new Course("Programming with C#");
            //Adding students to the object course:
            cs1.St[0] = st1;
            cs1.St[1] = st2;
            cs1.St[2] = st3;
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
            Console.WriteLine("The number of students enrolled in the {0} course: {1}.", cs1.Name, Student.GetNumOfStudents());

        }
    }
    public class Student
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
        // The static int to count the number of instances of the student class
        private static int NumOfStudents = 0;
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
        public Student()
        {
            NumOfStudents += 1;
        }
        public static int GetNumOfStudents()
        {
            return NumOfStudents;
        }
        public Student(String name = "Blank", String surname = "Blank", String birthday = "Blank", String addline1 = "Blank", String addline2 = "Blank", int zip = 0, String city = "Blank", String state = "Blank", String country = "Blank")
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Addline1 = addline1;
            this.Addline2 = addline2;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Zip = zip;
            NumOfStudents++;
        }

    }
    public class Teacher
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
        public Teacher(String name = "Blank", String surname = "Blank", String birthday = "Blank", String addline1 = "Blank", String addline2 = "Blank", int zip = 0, String city = "Blank", String state = "Blank", String country = "Blank")
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
    public class UProgram
    {
        public string Name { get; set; }
        public Degree Deg { get; set; } //This property (Deg) will hold the degree class 
        public UProgram(string name)
        {
            this.Name = name;
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
    public class Course
    {
        public string Name { get; set; }
        private Student[] st = new Student[3];
        public Student[] St
        {
            get
            {
                return st;
            }
            set
            {
                st = value;
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
    }
}

//A code of a peer which is interesting.
//using System;

//namespace Lab5
//{
//    class MainClass
//    {
//        public static void Main(string[] args)
//        {
//            Student[] students = new Student[3] { new Student("Anna", "Zharkova"), new Student("Ivan", "Ivanov"), new Student("Petr", "Petrov") };
//            Course course = new Course("Programming with C#");

//            course.Students = students;

//            Teacher[] teachers = new Teacher[3];
//            teachers[0] = new Teacher("Sergei", "Zhilin");

//            course.Teachers = teachers;

//            Degree degree = new Degree("Bachelor");
//            degree.CourseInfo = course;

//            UProgram program = new UProgram("Information Technology");
//            program.DegreeInfo = degree;

//            Console.WriteLine("The {0} program contains of {1} of Science degree", program.ProgramName, program.DegreeInfo.DegreeName);
//            Console.WriteLine("The {0} of Science degree containce the course {1} ", program.DegreeInfo.DegreeName, program.DegreeInfo.CourseInfo.CourseName);
//            Console.WriteLine("The {0} contains {1} student(s)", program.DegreeInfo.CourseInfo.CourseName, program.DegreeInfo.CourseInfo.Students.Length);

//        }
//    }
//    public class UProgram
//    {
//        private Degree degreeInfo;
//        private string departmentHead;
//        private string programName;
//        private string university;

//        public string DepartmentHead { get { return departmentHead; } set { departmentHead = value; } }

//        public string ProgramName { get { return programName; } set { programName = value; } }

//        public string University { get { return university; } set { university = value; } }

//        public Degree DegreeInfo { get { return degreeInfo; } set { degreeInfo = value; } }

//        public UProgram()
//        {
//        }
//        public UProgram(string name)
//        {
//            this.programName = name;
//        }
//    }
//    public class Student
//    {
//        private string firstName;
//        private string lastName;
//        private DateTime birthDay;

//        private string address1;
//        private string address2;
//        private string city;
//        private string state;
//        private string zip;
//        private string country;

//        public string FirstName { get { return firstName; } set { firstName = value; } }
//        public string LastName { get { return lastName; } set { lastName = value; } }

//        public string BirthDay { get { return birthDay.ToString("dd.MM.yyyy"); } set { DateTime.TryParse(value, out birthDay); } }

//        public string Address1 { get { return address1; } set { address1 = value; } }
//        public string Address2 { get { return address2; } set { address2 = value; } }
//        public string City { get { return city; } set { city = value; } }
//        public string State { get { return state; } set { state = value; } }
//        public string Zip { get { return zip; } set { zip = value; } }
//        public string Country { get { return country; } set { country = value; } }

//        public Student()
//        {
//            this.firstName = "first name";
//            this.lastName = "last name";
//        }

//        public Student(string firstName, string lastName)
//        {
//            this.firstName = firstName;
//            this.lastName = lastName;
//        }
//    }
//    public class Teacher
//    {
//        private string firstName;
//        private string lastName;
//        private string degree;

//        public string FirstName { get { return firstName; } set { firstName = value; } }
//        public string LastName { get { return lastName; } set { lastName = value; } }
//        public string Degree { get { return degree; } set { degree = value; } }

//        public Teacher()
//        {
//            this.firstName = "first name";
//            this.lastName = "last name";
//        }

//        public Teacher(string firstName, string lastName)
//        {
//            this.firstName = firstName;
//            this.lastName = lastName;
//        }
//    }
//    public class Degree
//    {
//        private string degreeName;
//        private bool isCreditRequired;
//        private Course courseInfo;

//        public string DegreeName { get { return degreeName; } set { degreeName = value; } }

//        public bool IsCreditRequired { get { return isCreditRequired; } set { isCreditRequired = value; } }

//        public Course CourseInfo { get { return courseInfo; } set { courseInfo = value; } }

//        public Degree()
//        {
//        }

//        public Degree(string name)
//        {
//            this.degreeName = name;
//        }
//    }
//    public class Course
//    {
//        private Student[] students;
//        public Student[] Students { get { return students; } set { students = value; } }

//        private Teacher[] teachers;
//        public Teacher[] Teachers { get { return teachers; } set { teachers = value; } }

//        private string courseName;

//        public string CourseName { get { return courseName; } set { courseName = value; } }

//        public Course()
//        {

//        }
//        public Course(string name)
//        {
//            this.courseName = name;
//        }
//    }
//}