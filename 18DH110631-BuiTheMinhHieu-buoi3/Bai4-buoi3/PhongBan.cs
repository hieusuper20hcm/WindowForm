using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_buoi3
{
    class PhongBan
    {
        NhanVien[] phongBan;
        public NhanVien this[int i]
        {
            get { return phongBan[i]; }
            set { phongBan[i] = value; }
        }

        public int soLuong;

        public PhongBan()
        {
            phongBan = new NhanVien[0];
        }

        public PhongBan(int soLuong)
        {
            phongBan = new NhanVien[soLuong];
            this.soLuong = soLuong;

            for (int i = 0; i < this.soLuong; i++)
            {
                this[i] = new NhanVien();
            }
        }
        public void Nhap()
        {
            for (int i = 0; i < soLuong; i++)
            {
                NhanVien nNhanVien = phongBan[i];
                Console.WriteLine("Nhan Vien Thu {0}: ", i + 1);
                Console.Write("Nhap Ho Ten: ");
                nNhanVien.hoTen = Console.ReadLine();
                Console.Write("Nhap Muc Luong: ");
                nNhanVien.mucLuong = double.Parse(Console.ReadLine());
                Console.Write("Nhap So Ngay Vang: ");
                nNhanVien.soNgayVang = int.Parse(Console.ReadLine());
            }
        }
        public void TongLuong()
        {
            double kq = 0;
            Console.Write("\nTong luong la: ");
            for (int i = 0; i < soLuong; i++)
            {
                NhanVien nNhanVien = phongBan[i];
                kq += phongBan[i].Luong();
            }
            Console.Write(kq);
        }
    }
}
