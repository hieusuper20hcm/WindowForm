using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_buoi3
{
    class DonThuc
    {
        private double heSo;
        private double soMu;

        public double HeSo { get => heSo; set => heSo = value; }
        public double SoMu { get => soMu; set => soMu = value; }

        public DonThuc()
        {
            HeSo = 1;
            SoMu = 0;
        }
        public DonThuc(double heSo,double soMu)
        {
            this.HeSo = heSo;
            this.SoMu = soMu;
        }
    }
}
