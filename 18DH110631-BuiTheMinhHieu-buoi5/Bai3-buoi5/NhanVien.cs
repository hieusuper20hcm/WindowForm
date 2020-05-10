using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi5
{
     abstract class NhanVien
    {
        private string maNV;
        private string hoTen;

        protected string MaNV { get => maNV; set => maNV = value; }
        protected string HoTen { get => hoTen; set => hoTen = value; }

        public NhanVien() { }
        public NhanVien(string maNV, string hoTen)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
        }
        public abstract double TinhLuong();
       

    }
}
