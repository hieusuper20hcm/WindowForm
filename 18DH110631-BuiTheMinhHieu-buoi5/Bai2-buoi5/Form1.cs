using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int tuSoA = int.Parse(txtTuSoA.Text);
                int mauSoA = int.Parse(txtMauSoA.Text);

                int tuSoB = int.Parse(txtTuSoB.Text);
                int mauSoB = int.Parse(txtMauSoB.Text);
                PhanSo phanSoA = new PhanSo(tuSoA, mauSoA);
                PhanSo phanSoB = new PhanSo(tuSoB, mauSoB);
                PhanSo KQ = phanSoA + phanSoB;
                KQ.RutGon();
                lblKetQua.Text = "Ket qua: " + KQ.toString();
                this.lblKetQua.Location = new System.Drawing.Point(Width/2-lblKetQua.Width/2,lblKetQua.Location.Y);

            }
            catch
            {
                MessageBox.Show("Vui long nhap so");
            }
        }
    }
}
