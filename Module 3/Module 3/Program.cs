using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInfo();
            GetCourseInfo();
            GetTeacherInfo();
            GetProgramInfo();
            try
            {
                bool check = birthvalid("12 12 2020");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("This method is not written yet.");
            }
            Console.ReadKey();

        }
        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday:");
            string birthday = Console.ReadLine();

            // Code to finish getting the rest of the student data
            PrintStudentDetails(firstName, lastName, birthday);
        }
        static void GetTeacherInfo()
        {
            Console.WriteLine("enter the first name of the teacher:");
            string tr_fname = Console.ReadLine();
            Console.WriteLine("Enter the last name of the teacher:");
            string tr_lname = Console.ReadLine();
            Console.WriteLine("Enter the age of the teacher:");
            string tr_age = Console.ReadLine();
            PrintTeacherInfo(tr_fname, tr_lname, tr_age);

        }
        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the name of the university program:");
            string pg_name = Console.ReadLine();
            Console.WriteLine("Enter the degree Offered:");
            string pg_degree = Console.ReadLine();
            Console.WriteLine("Enter the name of the institute offering the program: ");
            string pg_instname = Console.ReadLine();
            PrintProgramInfo(pg_name, pg_degree, pg_instname);

        }
        static void GetCourseInfo()
        {
            Console.WriteLine("Enter the name of the course:");
            string cs_name = Console.ReadLine();
            Console.WriteLine("Enter the credits of the course:");
            string cs_credit = Console.ReadLine();
            Console.WriteLine("Enter the duration of the course:");
            string cs_duration = Console.ReadLine();
            PrintCousreInfo(cs_name, cs_credit, cs_duration);

        }
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}.", first, last, birthday);
        }
        static void PrintCousreInfo(string name, string credit, string duration)
        {
            Console.WriteLine("Course is {0} with total credit of {1} and it takes about {2}.", name, credit, duration);
        }
        static void PrintTeacherInfo(string fname, string lname, string age)
        {
            Console.WriteLine("Teacher {0} {1} is {2} years old.", fname, lname, age);
        }
        static void PrintProgramInfo(string name, string degree, string provider)
        {
            Console.WriteLine("The program named {0} is offered by {1} and the degree is {2}.", name, provider, degree);
        }
        static bool birthvalid(string bdate)
        {
            throw new NotImplementedException();
        }
    }
}

