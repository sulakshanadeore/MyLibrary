using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public delegate int Operations(int i, int j);
    public class Maths
    {

        public int Add(int i, int j)
        {
            return i + j;
        }


        public int Sub(int i, int j)
        {
            return i - j;
        }
        public int Mult(int i, int j)
        {
            return i * j;
        }
    }
}
