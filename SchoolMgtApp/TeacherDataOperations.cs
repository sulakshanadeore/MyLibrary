using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMgtApp
{
    

     class TeacherDataOperations:EventArgs
    {
        static event NewTeacher TeacherJoining;
        static void Main(string[] args)
        {
            SeniorTeacher sr=new SeniorTeacher();
            int i = 0;
            bool ans1 = false;
           SeniorTeacher[] teachersdata = new SeniorTeacher[4];
            
            do
            {
                           
            Console.WriteLine("R u  a new teacher");
            bool ans = Convert.ToBoolean(Console.ReadLine());
            if (ans)
            {
                Console.WriteLine("Enter name");
                sr.Tname = Console.ReadLine();
                Console.WriteLine( "Enter subject");
                sr.Sname = Console.ReadLine();
                NewTeacher t = new NewTeacher(sr.TeacherDetails);
                TeacherJoining += t;

                    TeacherJoining(sr.Tname, sr.Sname);
                    teachersdata[i] = new SeniorTeacher();
                    teachersdata[i].Tname = sr.Tname;
                    teachersdata[i].Sname = sr.Sname;


            }

                Console.WriteLine( "Any more new teachers joined?");
                ans1 = Convert.ToBoolean(Console.ReadLine());
                i++;
            } while (ans1);

            Console.WriteLine( "Now printing all the teacher data received");
            foreach (var item in teachersdata)
            {
                Console.WriteLine(  item.Tname);
                Console.WriteLine(  item.Sname);
            }


            Console.ReadLine();



        }
    }
}
