using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public delegate void NewTeacher(string tname, string subname);
    public class Teacher
    {
        public Teacher()
        {
            Console.WriteLine("Default constructor of teacher class");
        }

        public int Age { get; set; }
        public Teacher(int age)
        {
            Age = age;
            Console.WriteLine($"Parameterised of Teacher class,  age called {Age} ");
        }


    }

    public class SeniorTeacher:Teacher
    {


        public SeniorTeacher()
        {
            Console.WriteLine( "Default constructor of senior teacher");
        }
        public void TeacherDetails(string tname, string subname)
        {
            Tname = tname;
            Sname = subname;

        }


        public string Tname { get; set; }
        public string Sname { get; set; }
        public SeniorTeacher(string name,string subjectname,int age):base(age)
        {
            Tname = name;
            Sname=subjectname;

            Console.WriteLine("Parameterised of name and subject name of senior teacher");
        }
    }

}
