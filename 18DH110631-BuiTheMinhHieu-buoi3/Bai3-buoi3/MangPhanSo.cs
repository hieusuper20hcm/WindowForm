using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_buoi3
{
    class MangPhanSo
    {
        private PhanSo[] mangPhanSo;
        private int soLuong;
        public PhanSo this[int i]
        {
            get { return mangPhanSo[i]; }
            set { mangPhanSo[i] = value; }
        }
        public MangPhanSo()
        {
            mangPhanSo = new PhanSo[1];
            mangPhanSo[0] = new PhanSo();
        }

        public MangPhanSo(int soLuong)
        {
            this.soLuong = soLuong;
            mangPhanSo = new PhanSo[soLuong];
            for (int i = 0; i < soLuong; i++)
            {
                mangPhanSo[i] = new PhanSo();
            }

        }
        public void Nhap()
        {
            for (int i = 0; i < this.soLuong; i++)
            {
                PhanSo nPhanSo = mangPhanSo[i];
                Console.WriteLine("Phan So Thu {0}", i + 1);
                Console.Write("Hay Nhap Tu So: ");
                nPhanSo.tuso = int.Parse(Console.ReadLine());
                Console.Write("Hay Nhap Mau So: ");
                nPhanSo.mauso = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < this.soLuong; i++)
            {
                PhanSo nPhanSo = this[i];
                Console.Write(nPhanSo.tuso + "/" + nPhanSo.mauso);
                if (i != soLuong - 1)
                {
                    Console.Write(" , ");
                }
            }
            Console.WriteLine();
        }
        public PhanSo Tong()
        {
            PhanSo kq = new PhanSo();
            for (int i = 0; i < this.soLuong; i++)
            {
                kq = kq + this[i];
            }
            kq.RutGon();
            return kq;
        }
    }
}
