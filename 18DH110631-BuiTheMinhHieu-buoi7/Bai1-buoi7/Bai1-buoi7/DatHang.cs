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
    public partial class DatHang : Form
    {
        private static readonly string connectString =
        "Server=DESKTOP-O11VVU5,1433;Database=QLQuan;User Id = sa; Password=hieusuper20hcm;";
        private string msdh;
        public DatHang(string MSDH)
        {
            InitializeComponent();
            this.msdh = MSDH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string mshh = txtMSHH.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            int tiLeGiam = int.Parse(txtTiLeGiam.Text);
            DonHang datHang = new DonHang();
            datHang.DatHang(this.msdh, mshh, soLuong, tiLeGiam);
            DatHang dat = new DatHang(msdh);
            DatHang_Load(dat, e);
        }

        private void DatHang_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("MSDH", 100);
            listView1.Columns.Add("MSHH", 100);
            listView1.Columns.Add("So Luong", 100);
            listView1.Columns.Add("Ti le giam", 100);
            string queryString = "SELECT * FROM DATHANG;";
            SqlConnection connect = new SqlConnection(connectString);
            SqlCommand command = new SqlCommand(queryString, connect);
            connect.Open();
            SqlDataReader reader = command.ExecuteReader();
            listView1.Clear();
            while (reader.Read())
            {
                ListViewItem ls = new ListViewItem(reader.GetString(0).ToString());
                ls.SubItems.Add(reader.GetString(1).ToString());
                ls.SubItems.Add(reader.GetInt32(2).ToString());
                ls.SubItems.Add(reader.GetInt32(3).ToString());
                listView1.Items.Add(ls);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
