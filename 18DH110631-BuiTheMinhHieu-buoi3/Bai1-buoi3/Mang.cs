using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_buoi3
{
    class Mang
    {
        private int[] a;

        public int this[int i] { get => a[i]; set => a[i] = value; }
        public Mang() {
            a = new int[1];
            a[0] = 2;
        }
        public Mang(int soLuong)
        {
            a = new int[soLuong];
        }
        public int length
        {
            get { return a.Length; }
        }
        public void Xuat()
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
        }
        public void SoChan()
        {
            for(int i=0;i<a.Length;i++)
            {
                if (this[i] % 2 == 0)
                    Console.Write(this[i] + " ");
               
            }
        }
    }
}
