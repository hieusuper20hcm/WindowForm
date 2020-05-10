using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_buoi5
{
    class PhanSo
    {
        public int tuso;
        public int mauso;

        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        private int UCLN(int a, int b)
        {
            if (a % b == 0) return b;
            return UCLN(b, a % b);
        }
        public void RutGon()
        {
            int ucln = UCLN(tuso, mauso);
            tuso = tuso / ucln;
            mauso = mauso / ucln;
        }
        public string toString()
        {
            return tuso + "/" + mauso;
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo p = new PhanSo();
            p.tuso = b.tuso * a.mauso + b.mauso * a.tuso;
            p.mauso = b.mauso * a.mauso;
            return p;
        }
    }
}
