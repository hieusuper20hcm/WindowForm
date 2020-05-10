using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc dathuc = new DaThuc(3);
            dathuc.Nhap();
            dathuc.Xuat();
            Console.Write("Nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dathuc.TinhDaThuc(x));
        }
    }
}
