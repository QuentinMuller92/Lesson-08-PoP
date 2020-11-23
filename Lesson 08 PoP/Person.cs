using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    public class Person
    {
        internal int age;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
