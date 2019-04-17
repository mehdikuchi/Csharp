using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    public struct student
    {
        public string Fname;
        public string Lname;
        public string Addr1;
        public string Addr2;
        public string Birthday;
        public string City;
        public string Country;
        public string State;
        public student(string fname, string lname, string addr1, string addr2, string birthday, string city, string country, string state)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Addr1 = addr1;
            this.Addr2 = addr2;
            this.Birthday = birthday;
            this.City = city;
            this.Country = country;
            this.State = state;
        }
    }
    public struct professor
    {
        public string Fname;
        public string Lname;
        public string Addr1;
        public string Addr2;
        public string Birthday;
        public string City;
        public string Country;
        public string State;
        public professor(string fname, string lname, string addr1, string addr2, string birthday, string city, string country, string state)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.Addr1 = addr1;
            this.Addr2 = addr2;
            this.Birthday = birthday;
            this.City = city;
            this.Country = country;
            this.State = state;
        }
    }
    public struct program
    {
        public string Name;
        public string Degree;          //can be M.Sc. B.Eng etc.
        public short Credits;          //total credits required for obtaining the qualification
        public string Type;            // full time or part time
        public program(string name, string degree, short credits, string type)
        {
            this.Name = name;
            this.Degree = degree;
            this.Credits = credits;
            this.Type = type;
        }
    }
    public struct course
    {
        public string Name;
        public short Length;
        public string Type;            // online or on campus
        public short Credit;            //The credit of the course
        public course(string name, short length, string type, short credit)
        {
            this.Name = name;
            this.Length = length;
            this.Type = type;
            this.Credit = credit;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            student[] students = new student[5];
            students[0] = new student("jack", "johnson", "somewhere street", "first alley", "8 12 1945", "London", "England", "newstate");
            Console.WriteLine("First student's first name: {0}.", students[0].Fname);
            Console.WriteLine("First student's last name: {0}.", students[0].Lname);
            Console.WriteLine("First student's address: {0}, {1}, {2}, {3}.", students[0].Addr1, students[0].Addr2, students[0].City, students[0].Country);
            Console.WriteLine("First student's state: {0}.", students[0].State);
            Console.WriteLine("First student's birth day: {0}.", students[0].Birthday);
            Console.ReadKey();
        }
    }
}