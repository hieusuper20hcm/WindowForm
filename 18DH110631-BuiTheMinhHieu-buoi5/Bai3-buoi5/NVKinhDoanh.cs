using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi5
{
    class NVKinhDoanh:NhanVien
    {
        private int soHD = 0;
        private int luongCB = 0;
        public static readonly int tienHD = 500000;
        public NVKinhDoanh() { }
        public NVKinhDoanh(string maNV, string hoTen, int luongCB, int soHD) : base(maNV, hoTen)
        {
            this.LuongCB = luongCB;
            this.SoHD = soHD;
        }

        public int LuongCB { get => luongCB; set => luongCB = value; }
        public int SoHD { get => soHD; set => soHD = value; }
        public override double TinhLuong()
        {
            return LuongCB + SoHD * tienHD;
        }
      
    }
}
