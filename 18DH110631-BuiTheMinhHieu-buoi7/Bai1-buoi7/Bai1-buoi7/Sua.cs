using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi7
{
    public partial class Sua : Form
    {
    
        public Sua()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChinhMoi_Click(object sender, EventArgs e)
        {
            string MSHH = txtMSHH.Text;
            string tenHang = txtTenHang.Text;
            int gia = int.Parse(txtGia.Text);
            bool tinhTrang = rdTrue.Checked ? true : false;
            Provider Chinh = new Provider();
            Chinh.ChinhSua(MSHH, tenHang, gia, tinhTrang);
            MessageBox.Show("Bạn Đã Chỉnh Sửa Thành Công", "Thông Báo!");
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
