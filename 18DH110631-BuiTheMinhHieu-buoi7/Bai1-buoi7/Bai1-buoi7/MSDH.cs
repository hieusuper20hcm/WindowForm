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
    public partial class MSDH : Form
    {
        public MSDH()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string msdh = txtMSDH.Text;
            DonHang themHoaDon = new DonHang();
            themHoaDon.TaoHoaDon(msdh, DateTime.Now);
            DatHang dat = new DatHang(msdh);
            dat.Show();
            this.Hide();
        }
    }
}
