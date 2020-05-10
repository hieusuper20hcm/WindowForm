using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ket qua {0} mu {1} la:{2}",x,y,Math.Pow(x,y));
        }
    }
}
