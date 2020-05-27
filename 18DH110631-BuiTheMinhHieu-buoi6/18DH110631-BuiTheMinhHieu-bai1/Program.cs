using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18DH110631_BuiTheMinhHieu_bai1
{
    class Program
    {
        public static void DanhSachNuoc(Provider danhSach)
        {
            danhSach.DanhSachThucUong();
        }
        public static void ThemNuoc(Provider themNuoc)
        {
            Console.Write("\nVui long nhap MSHH can them: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui long nhap ten nuoc can them: ");
            string tenhang = Console.ReadLine();
            Console.Write("Vui long nhap gia can them: ");
            int gia = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap tinh trang can them: ");
            bool tinhtrang = bool.Parse(Console.ReadLine());
            themNuoc.ThemNuoc(mshh, tenhang, gia, tinhtrang);
            themNuoc.DanhSachThucUong();
        }
        public static void XoaNuoc(Provider xoaNuoc)
        {
            Console.Write("Vui long nhap MSHH can xoa: ");
            string mshh = Console.ReadLine();
            xoaNuoc.XoaNuoc(mshh);
            xoaNuoc.DanhSachThucUong();
        }
        public static void ChinhSua(Provider chinhSua)
        {
            Console.Write("\nVui long nhap MSHH can chinh sua: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui long nhap ten nuoc can chinh sua : ");
            string tenhang = Console.ReadLine();
            Console.Write("Vui long nhap gia can chinh sua: ");
            int gia = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap tinh trang chinh sua: ");
            bool tinhtrang = bool.Parse(Console.ReadLine());
            chinhSua.ChinhSua(mshh, tenhang, gia, tinhtrang);
            chinhSua.DanhSachThucUong();
        }
        public static void DatHang(DonHang datHang)
        {
            Console.Write("\nVui long nhap MSDH can dat: ");
            string msdh = Console.ReadLine();
            Console.Write("Vui long nhap MSHH can dat: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui long nhap so luong: ");
            int soluong = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap ti le giam: ");
            int tilegiam = int.Parse(Console.ReadLine());
            datHang.DatHang(msdh, mshh, soluong, tilegiam);
            datHang.TaoHoaDon(msdh, DateTime.Now);
            datHang.DanhSachHoaDon();

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Provider thucuong = new Provider();
            DanhSachNuoc(thucuong);
            //ThemNuoc(thucuong);
            //XoaNuoc(thucuong);
            ChinhSua(thucuong);
            //DonHang donHang1 = new DonHang();
            //DatHang(donHang1);
            

        }
    }
}
