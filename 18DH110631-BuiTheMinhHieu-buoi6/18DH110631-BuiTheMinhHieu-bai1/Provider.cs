using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _18DH110631_BuiTheMinhHieu_bai1
{
    class Provider
    {
        private static readonly string connectionString =
            "Server=DESKTOP-O11VVU5,1433;Database=QLQuan;User Id=sa;Password=hieusuper20hcm;"; 
        public Provider() { }
        public void DanhSachThucUong()
        {
            string queryString =
            "SELECT * From ThucUong";


            // Specify the parameter value.

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}",
                            reader[0], reader[1], reader[2],reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ThemNuoc(string msHH, string tenHang, int gia, bool tinhTrang)
        {
            string queryString =
            "INSERT INTO ThucUong(MSHH,TenHang,Gia,TinhTrang)"+
            "VALUES(@msHH, @tenHang, @gia, @tinhTrang)";

            // Specify the parameter value.

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@msHH", msHH);
                command.Parameters.AddWithValue("@tenHang", tenHang);
                command.Parameters.AddWithValue("@gia", gia);
                command.Parameters.AddWithValue("@tinhTrang", tinhTrang);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void XoaNuoc(string MSHH)
        {
            string queryString =
            "DELETE FROM ThucUong WHERE MSHH=@MSHH";

            // Specify the parameter value.
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", MSHH);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void ChinhSua(string msHH,string tenHang, int gia, bool tinhTrang)
        {
            string queryString = "UPDATE ThucUong " +
                                    "SET TenHang =@tenHang, Gia = @gia, TinhTrang = @tinhTrang" +
                                    " WHERE MSHH=@msHH";


            // Specify the parameter value.
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSHH", msHH);
                command.Parameters.AddWithValue("@TenHang", tenHang);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}
