using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi7
{
    public partial class Them : Form
    {
        public Them()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string MSHH = txtMSHH.Text;
            string tenHang = txtTenHang.Text;
            int gia = int.Parse(txtGia.Text);
            bool tinhTrang = rdTrue.Checked ? true : false;
            Provider pro = new Provider();
            pro.ThemNuoc(MSHH, tenHang, gia, tinhTrang);
            MessageBox.Show("Bạn Đã Thêm Thành Công", "Thông Báo!");
            Clear();
        }
        private void Clear()
        {
            txtMSHH.Text = "";
            txtTenHang.Text = "";
            txtGia.Text = "";
            rdTrue.Checked = true;
        }
    }
}
