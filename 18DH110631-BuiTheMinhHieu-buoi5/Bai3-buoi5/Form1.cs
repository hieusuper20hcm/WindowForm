using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            View();
        }
        private void View()
        {
            rdbtnNVKD.Checked = true;
            
        }

        private void btnLuong_Click(object sender, EventArgs e)
        {
            NhanVien nv;
            string maNV = txtMANV.Text;
            string hoTen = txtHoTen.Text;
            bool isNVKD = rdbtnNVKD.Checked;
            if (isNVKD)
            {
                nv = new NVKinhDoanh(maNV, hoTen, int.Parse(txtLuongCoBan.Text), int.Parse(txtSoHopDong.Text));
            }
            else nv = new NVSanXuat(maNV, hoTen, int.Parse(txtSoLuong.Text));
            lblLuong.Text = nv.TinhLuong().ToString();
        }
        private void Clear()
        {
            txtSoLuong.Text = "";
            txtSoHopDong.Text = "";
            txtLuongCoBan.Text = "";

        }
        private void rdbtnNVSX_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            txtLuongCoBan.Enabled = false;
            txtSoHopDong.Enabled = false;
            txtSoLuong.Enabled = true;
        }

        private void rdbtnNVKD_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            txtSoLuong.Enabled = false;
            txtSoHopDong.Enabled = true;
            txtLuongCoBan.Enabled = true;
        }
    }
}
