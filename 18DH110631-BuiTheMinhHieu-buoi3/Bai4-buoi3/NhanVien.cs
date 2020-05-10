using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_buoi3
{
    class NhanVien
    {
        public string hoTen;
        public double mucLuong;
        public int soNgayVang;

        public NhanVien() { }

        public NhanVien(string hoTen, double mucLuong, int soNgayVang)
        {
            this.hoTen = hoTen;
            this.mucLuong = mucLuong;
            this.soNgayVang = soNgayVang;
        }

        public double Luong()
        {
            double luong;
            luong = mucLuong - soNgayVang * 100000;
            if (luong < 0)
                return 0;
            return luong;
        }
    }
}
