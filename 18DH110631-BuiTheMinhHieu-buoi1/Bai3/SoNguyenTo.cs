using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class SoNguyenTo
    {
        public int n;
        public SoNguyenTo(int n)
        {
            this.n = n;
        }
        public bool KTSoNguyenTo()
        {
                if (n < 2)

                return false;

            for (int i = 2; i < n; i++)

                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
