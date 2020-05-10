using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_buoi3
{
    class DaThuc
    {
        private DonThuc[] mangDonThuc;
        private int soLuong;

        public DonThuc this[int i]
        {
            get { return mangDonThuc[i]; }
            set { mangDonThuc[i] = value; }
        }
        public DaThuc()
        {
            mangDonThuc = new DonThuc[1];
            mangDonThuc[0] = new DonThuc();

        }
        public DaThuc(int soLuong)
        {
            this.soLuong = soLuong;
            mangDonThuc = new DonThuc[soLuong];
            for (int i = 0; i < soLuong; i++)
            {
                mangDonThuc[i] = new DonThuc(1, i);
            }
        }
        public void Nhap()
        {
            for (int i = 0; i < soLuong; i++)
            {
                DonThuc donthuc = this[i];
                donthuc.SoMu = i;
                Console.Write("Vui long nhap he so a tai don thuc thu " + i + " :");
                donthuc.HeSo = double.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.WriteLine("In da thuc:");
            for (int i = 0; i < soLuong; i++)
            {
                DonThuc donthuc = mangDonThuc[i];
                Console.Write(donthuc.HeSo + "*" + "x^" + donthuc.SoMu);
                if (i != soLuong - 1)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }
        public double TinhDaThuc(double x)
        {
            double kq = 0;
            for (int i = 0; i < soLuong; i++)
            {
                DonThuc nDonThuc = mangDonThuc[i];
                kq += nDonThuc.HeSo * Math.Pow(x, nDonThuc.SoMu);
            }
            return kq;
        }

    }
}
