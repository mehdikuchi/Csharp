using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //below is the attributes for a student
            string st_fname = "john", st_lname = "stuart";
            DateTime st_birthdate = new DateTime(1989, 05, 2);
            string st_addline1 = "somwhere street";
            string st_addline2 = "first alley";
            string st_city = "London";
            string st_country = "england";
            string st_state = "some state";
            int st_zipcode = 10007;
            //below is the attributes for a professor
            string pf_fname = "edward", pf_lname = "denilson";
            DateTime pf_birthdate = new DateTime(1949, 11, 12);
            string pf_addline1 = "somwhere street";
            string pf_addline2 = "third alley";
            string pf_city = "London";
            string pf_country = "england";
            string pf_state = "some state";
            int pf_zipcode = 12007;
            string pf_field = "machine learning";
            string pf_degree = "Associate professor";
            //below we provide some information about a university program
            string pg_name = "Electrical engineering";
            string pg_degrees = "bachelor of science";
            string dp_head = "david fry";
            //below a course information is provided
            string cs_name = "Electrical circuits 1";
            short cs_credit = 3;
            string cs_type = "full time";
            Console.WriteLine("student information are as follows:");
            Console.WriteLine("Name and surname: {0} {1}.", st_fname, st_lname);
            Console.WriteLine("Student's address: {0}, {1}, {2}, {3}.", st_addline1, st_addline2, st_city, st_country);
            Console.WriteLine("student's state and zip code, respectively: {0}, {1}.", st_state, st_zipcode);
            Console.WriteLine();
            Console.WriteLine("a professor information are as follows:");
            Console.WriteLine("professor's name and surname: {0}, {1}.", pf_fname, pf_lname);
            Console.WriteLine("professors's address: {0}, {1}, {2}, {3}.", pf_addline1, pf_addline2, pf_city, pf_country);
            Console.WriteLine("professor's state and zip code, respectively: {0}, {1}.", pf_state, pf_zipcode);
            Console.WriteLine("professor's field of interest and degree, respectively: {0}, {1}.", pf_field, pf_degree);
            Console.WriteLine();
            Console.WriteLine("information regarding a university program:");
            Console.WriteLine("program name: {0}, study level: {1}.", pg_name, pg_degrees);
            Console.WriteLine("the department head is: {0}.", dp_head);
            Console.WriteLine();
            Console.WriteLine("a typical course description is as follows:");
            Console.WriteLine("course name: {0}, total credit of the course is {1} and the type of study is {2}.", cs_name, cs_credit, cs_type);



        }
    }
}

//using System;

//namespace Assignment
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string firstName, lastName, birthday, addressLine1, addressLine2,
//            city, stateProvince, country, programName, degreeOffered, departmentHead;
//            int zipOrPostal;
//            firstName = "CHAN";
//            lastName = "CHI SHING";
//            birthday = "11/12/1995";
//            addressLine1 = "ROOM 18 WING ON BUILDING";
//            addressLine2 = "32 CANTON ROAD KOWLOON";
//            city = "HONG KONG";
//            stateProvince = "GUANGDONG";
//            country = "CHINA";
//            zipOrPostal = 852;
//            programName = "Bachelor of Computer Science";
//            degreeOffered = "Honor Degree";
//            departmentHead = "JOHN CHEUNG";
//            Console.WriteLine("========================================");
//            Console.WriteLine("First Name: {0}", firstName);
//            Console.WriteLine("Last Name: {0}", lastName);
//            Console.WriteLine("Birthday: {0}", birthday);
//            Console.WriteLine("Address Line 1: {0}", addressLine1);
//            Console.WriteLine("Address Line 2: {0}", addressLine2);
//            Console.WriteLine("City: {0}", city);
//            Console.WriteLine("State/Province: {0}", stateProvince);
//            Console.WriteLine("Country: {0}", country);
//            Console.WriteLine("Zip/Postal: {0}", zipOrPostal);
//            Console.WriteLine("Program name: {0}", programName);
//            Console.WriteLine("Degrees offered: {0}", degreeOffered);
//            Console.WriteLine("Department Head: {0}", departmentHead);
//            Console.WriteLine("========================================");
//        }
//    }
//}

/**
* April 17th, 2015
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpCourse
//{

//    public class Assignment01
//    {

//        public static void Main(string[] args)
//        {

//            //Student's Personal Information
//            string name = "Jonathan";
//            string surname = "Brown";
//            int age = 31;

//            //Student's Educational Background
//            string country = "the United Kingdom";
//            string degree = "BA in Biology";
//            string university = "University of Manchester";

//            //Student's Economic Situation
//            double gdp = 1342.37;
//            bool parent = false;

//            Console.WriteLine("The student's full name is " + name + " " + surname + ".");
//            Console.WriteLine(name + " " + surname + " is " + age + " years old, " +
//            "lives in " + country + ", and got his " + degree +
//            " from the " + university + ".");
//            Console.WriteLine("The student's GDP is " + gdp + " and any assertion that " +
//            name + " " + surname + " is a parent is " + parent + ".");
//        }
//    }
//}