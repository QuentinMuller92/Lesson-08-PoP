using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    public class SquareData : Square
    {
        public SquareData(int sideLength) : base(sideLength)
        {

        }

        public int getPerimeter()
        {
            return (4*sideLength);
        }

        public int getArea()
        {
            return (sideLength * sideLength);
        }
    }
}
