using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Ho Ten Sinh Vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            int namSinh = Convert.ToInt32(Console.ReadLine());
            while(namSinh>DateTime.Now.Year)
            {
                Console.Write("Nhap lai nam sinh: ");
                namSinh = Convert.ToInt32(Console.ReadLine());
            }

            SinhVien sinhvien = new SinhVien(hoTen, namSinh);

            Console.WriteLine("Phuong Thuc Thanh Vien");
            Console.WriteLine("Tuoi Cua Sinh Vien La: " + sinhvien.xuLyTuoi());

            Console.WriteLine("Phuong Thuc Tinh");
            Console.WriteLine("Tuoi Cua Sinh Vien La: " + SinhVien.xuLyTuoiTinh(sinhvien));
        }
    }
}
