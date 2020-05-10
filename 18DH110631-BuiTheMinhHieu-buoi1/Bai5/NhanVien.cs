using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class NhanVien
    {
        private string hoTen;
        private int mucLuong;
        private int soNgayVang;

        public NhanVien() { }
        public NhanVien(string hoTen, int mucLuong, int soNgayVang)
        {
            this.HoTen = hoTen;
            this.MucLuong = mucLuong;
            this.SoNgayVang = soNgayVang;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int MucLuong { get => mucLuong; set => mucLuong = value; }
        public int SoNgayVang { get => soNgayVang; set => soNgayVang = value; }
        public void Nhap()
        {
            Console.Write("Moi nhap Ho ten NV: ");
            hoTen = Console.ReadLine();
            Console.Write("Muc luong: ");
            int.TryParse(Console.ReadLine(), out mucLuong);
            Console.Write("So ngay vang: ");
            int.TryParse(Console.ReadLine(), out soNgayVang);
        }
        public double getLuong()
        {
            if (mucLuong - soNgayVang * 100000 < 0)
                return 0;
            else return mucLuong - soNgayVang * 100000;
        }
        public void Xuat()
        {
            Console.WriteLine("Ho ten: "+HoTen);
            Console.WriteLine("So ngay vang: "+soNgayVang);
            Console.WriteLine("Luong: "+getLuong());
        }
    }
}
