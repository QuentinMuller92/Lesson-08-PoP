using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    internal class Printdata
    {
        internal void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        internal void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        internal void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }
}
