using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi2
{
    class SinhVien
    {
        private string hoTen;
        private int namSinh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public SinhVien(string hoTen, int namSinh)
        {
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
        }

        public int xuLyTuoi()
        {
            int TuoiSinhVien = DateTime.Now.Year - NamSinh;
            return TuoiSinhVien;
        }

        public static int xuLyTuoiTinh(SinhVien sv)
        {

            int TuoiSinhVien = DateTime.Now.Year - sv.NamSinh;
            return TuoiSinhVien;
        }
    }
}
