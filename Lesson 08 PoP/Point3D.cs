using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    internal class Point3D : Point
    {
        public int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
    }
}
