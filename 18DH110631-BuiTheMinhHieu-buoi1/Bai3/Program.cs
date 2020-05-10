using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SoNguyenTo t = new SoNguyenTo(n);
            if(t.KTSoNguyenTo()==true)
            {
                Console.WriteLine("{0} la so nguyen to",n);
            }
            else Console.WriteLine("{0} khong la so nguyen to", n);

        }
    }
}
