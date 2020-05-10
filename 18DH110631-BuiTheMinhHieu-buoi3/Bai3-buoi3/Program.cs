using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong: ");
            int n = Convert.ToInt32(Console.ReadLine());
            MangPhanSo phanso = new MangPhanSo(n);
            phanso.Nhap();
            phanso.Xuat();
            Console.WriteLine("Tong: "+ phanso.Tong().toString());
          
        }
    }
}
