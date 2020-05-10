using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi5
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
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);
                lblKetQua.Text = "x mu y la: " + Math.Pow(x, y);
            }
            catch
            {
                MessageBox.Show("Vui long nhap so");
            }
        }
    }
}
