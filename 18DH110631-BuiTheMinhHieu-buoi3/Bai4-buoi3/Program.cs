using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            PhongBan phongban = new PhongBan(2);
            phongban.Nhap();
            phongban.TongLuong();
            Console.WriteLine();
        }
    }
}
