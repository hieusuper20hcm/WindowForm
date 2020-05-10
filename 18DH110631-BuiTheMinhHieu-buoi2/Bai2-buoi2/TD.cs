using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_buoi2
{
    class TD:Point
    {
        Point A;
        Point B;
        public TD(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        public Point TDI()
        {
            double xi, yi;
            xi = (B.X + A.X) / 2;
            yi = (B.Y + A.Y) / 2;
            Point I = new Point(xi, yi);
            return I;
        }
        public static Point TDITinh(Point A, Point B)
        {
            double xi, yi;
            xi = (B.X + A.X) / 2;
            yi = (B.Y + A.Y) / 2;
            Point I = new Point(xi, yi);
            return I;
        }
    }
}
