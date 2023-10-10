using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public delegate void MultiOperations(int i, int j);
    public class AnotherMaths
    {
        public void Addition(int i, int j)
        {
            Console.WriteLine(i + j);
        }
        public void Subtraction(int i, int j)
        {
            Console.WriteLine(i - j);
        }
        public void Multiplication(int i, int j)
        {
            Console.WriteLine(i * j);
        }
    }
}
