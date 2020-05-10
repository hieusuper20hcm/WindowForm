using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_buoi2
{
    class Vector:Point
    {
        Point A, B;
        public Vector(Point A, Point B)
        {
            X = B.X - A.X;
            Y= B.Y - A.Y;
        }

        public double DoDai()
        {
            double doDai = Math.Sqrt(X*X+Y*Y);
            return doDai;
        }

        public static double DoDaiTinh(Point A, Point B)
        {
            double x, y;
            x = B.X - A.X;
            y = B.Y - A.Y;
            return Math.Sqrt(x * x + y * y);
        }
    }
}
