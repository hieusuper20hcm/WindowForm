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
    public partial class Xoa : Form
    {
        public Xoa()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Provider Xoa = new Provider();
            Xoa.XoaNuoc(txtMSHH.Text);
            MessageBox.Show("Bạn Đã Xóa Thành Công", "Thông Báo!");
            txtMSHH.Text = "";
        }
    }
}
