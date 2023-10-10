using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    //Step1: declared the delegate for ShowDetails() and the signature must match
    public delegate void Print();
    
    public class Student
    {

       
        //Access specifiers not allowed on static constructor
        static Student()
        {
            //first constructor to be called in the sequnece and it is called only once in tle lifetime of the class
            Console.WriteLine(  "Static  constructor called");
            Console.WriteLine("Used for initialising the data of the app for the entity");

        }
        public Student()
        {
            Console.WriteLine("Default constructore called");
        }

        public Student(int rollno,string name,string city)
        {
            RollNo = rollno;    
            StudentName = name;
            City = city;
            Console.WriteLine("Rollno,name and city parameterised constructor called");
        }
        public Student(int rollno,string name,int age)
        {
            RollNo = rollno;
            StudentName = name;
            this.age= age;
            Console.WriteLine("Rollno,name and age parameterised constructor called");
        }

        public Student(int rollno,string name,int age,string city):this(rollno,name,age)
        {

            City = city;
        }
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string City { get; set; }
        public int age { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"{RollNo} \n {StudentName} \n {City} \n{age}");

        }

    }
}
