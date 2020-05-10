using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_buoi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang mang = new Mang(5);
            for (int i = 0; i < mang.length; i++)
            {
                Console.WriteLine("Nhap gia tri phan tu thu " + i + " :");
                mang[i] = int.Parse(Console.ReadLine());
            }
            mang.Xuat();
            Console.WriteLine("Cac so chan la:");
            mang.SoChan();

        }
    }
}
