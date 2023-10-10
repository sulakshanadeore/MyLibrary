using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtApp
{
    internal class Program:EventArgs
    {
        //events are declared in the class
        //public static event Print WhenDetailsReceived;
        public static event Operations DoCalculation;
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter first no");
            int fno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no");
            int sno = Convert.ToInt32(Console.ReadLine());
            Maths m = new Maths();
            Console.WriteLine( "Enter operation u want to perform");
            int userchoice=Convert.ToInt32(Console.ReadLine()); 
            switch (userchoice)
            {
                case 1:
                    //Delegate is event handler
                    //Operations opAdd = new Operations(m.Add);//m.add is called method that is executed when the delegate recieves a call using opAdd is delegate object
                    //DoCalculation += opAdd;//DoCalculation is event

                    DoCalculation += new Operations(m.Add);


                    int addans = DoCalculation(fno, sno);
                    //When event fires the delegates gives a call to the handler of the event which is method.
                    Console.WriteLine(addans);
                    break;

                    //Unicast Delegate----> one method is passed to the delegate object
                case 2:
                    Operations opSub = new Operations(m.Sub);
                    DoCalculation += opSub;
                    int subans = DoCalculation(fno, sno);
                    Console.WriteLine(subans);
                    break;
                case 3:
                    Operations opmul = new Operations(m.Mult);
                    DoCalculation += opmul;
                    int multans = DoCalculation(fno, sno);
                    Console.WriteLine(multans);
                    break;

                


                default:
                    break;
            }


            





            //Student s=new Student();
            //Student s1 = new Student(1, "Aditi", 22);
            //Student s2 = new Student(3, "Jack", "Pune");

            //SeniorTeacher sr = new SeniorTeacher("Parinithi", "Maths",30);

            //   Student s = new Student(101, "Gauri", 23, "Bangalore");



            //Step 2: Create  a object of the delegate, becoz delegate is a reference type, for reference type we create object
            // Print p = new Print(s.ShowDetails);//Wiring delegate with method

            //WhenDetailsReceived += p;//wiring event with delegate
            //Print p = new Print(s.ShowDetails()); Wrong
            //Step 3: Call the delegate/Invoke the delegate
            // p();
            //WhenDetailsReceived();






            Console.Read();

            

        }
    }
}
