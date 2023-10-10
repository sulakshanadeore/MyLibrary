using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace SchoolMgtApp
{
    internal class SecondMain:EventArgs
    {
        static event MultiOperations DoAllOperations;
        static void Main(string[] args)
        {
            //Multi cast return type  must always be of type void
            AnotherMaths m1 = new AnotherMaths();
            MultiOperations[] operationsArr = new MultiOperations[3] {m1.Addition,m1.Multiplication, m1.Subtraction };
            
            Console.WriteLine("Enter first no");
            int fno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second no");
            int sno = Convert.ToInt32(Console.ReadLine());

            MultiOperations myarrCombined=(MultiOperations)MulticastDelegate.Combine(operationsArr);
            //    myarrCombined(fno,sno);
            DoAllOperations += myarrCombined;
            DoAllOperations(fno, sno);

            Console.Read();





        }
    }
}
