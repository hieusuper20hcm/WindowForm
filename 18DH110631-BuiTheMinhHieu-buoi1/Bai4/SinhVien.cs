using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SinhVien
    {
        private string maSV;
        private string hoTen;
        private string diaChi;
        private int soNam;

        public SinhVien()
        { }

        public SinhVien(string maSV, string hoTen, string diaChi, int soNam)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.soNam = soNam;
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int SoNam { get => soNam; set => soNam = value; }

        public void Nhap()
        {
            Console.Write("Moi nhap Ma SV: ");
            maSV = Console.ReadLine();
            Console.Write("Moi nhap Ho ten SV: ");
            hoTen = Console.ReadLine();
            Console.Write("Moi nhap Dia Chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Sinh vien nam: ");
            int.TryParse(Console.ReadLine(), out soNam);

            while (soNam > 4 || soNam <= 0)
            {
                Console.Write("Vui long nhap lai sinh vien nam: ");
                int.TryParse(Console.ReadLine(), out soNam);
            }
        }
        public void Xuat()
        {
            Console.WriteLine("MSSV: {0} - HoTen: {1}", maSV, hoTen);
            Console.WriteLine("Dia chi: " + diaChi);
            Console.WriteLine("Sinh vien nam: " + soNam);
        }
    }
}
