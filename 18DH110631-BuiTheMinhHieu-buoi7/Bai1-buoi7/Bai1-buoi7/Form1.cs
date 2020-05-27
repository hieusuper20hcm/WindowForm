using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai1_buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly string connectionString =
            "Server=DESKTOP-O11VVU5,1433;Database=QLQuan;User Id=sa;Password=hieusuper20hcm;";
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("MSHH", 100);
            listView1.Columns.Add("TenHang", 100);
            listView1.Columns.Add("Gia", 100);
            listView1.Columns.Add("TinhTrang", 100);
            string queryString = "Select * From ThucUong;";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                //Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                //Open the connection in a try/catch block.
                //Create and execute the DataReader, writing the result
                //set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader.GetString(0).ToString());
                        lv.SubItems.Add(reader.GetString(1).ToString());
                        lv.SubItems.Add(reader.GetInt32(2).ToString());
                        lv.SubItems.Add(reader.GetBoolean(3).ToString());
                        listView1.Items.Add(lv);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }

        private void OnCloseForm(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            this.Enabled = true;
            Form1_Load(form1, e);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Them ThemMoi = new Them();
            ThemMoi.Show();
            ThemMoi.FormClosed += new FormClosedEventHandler(OnCloseForm);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Sua Sua = new Sua();
            Sua.Show();
            Sua.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Xoa Xoa = new Xoa();
            Xoa.Show();
            Xoa.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            MSDH MSDH = new MSDH();
            MSDH.Show();
            MSDH.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }
    }
}

