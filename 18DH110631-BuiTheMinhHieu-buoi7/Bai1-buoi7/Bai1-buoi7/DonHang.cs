using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_buoi7
{
    class DonHang
    {
        private static readonly string connectionString =
            "Server=DESKTOP-O11VVU5,1433;Database=QLQuan;User Id=sa;Password=hieusuper20hcm;";
        public DonHang() { }
        public void DanhSachHoaDon()
        {
            string queryString =
            "SELECT * From HoaDon";


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
                        Console.WriteLine("{0}\t\t{1}",
                            reader[0], reader[1]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void TaoHoaDon(string MSDH, DateTime NgayDat)
        {
            string queryString =
            "INSERT INTO HoaDon(MSDH,NgayDat)" +
            "VALUES (@MSDH,@NgayDat)";


            // Specify the parameter value.
            //string NgayDat = ngayDat.ToString();
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
                command.Parameters.AddWithValue("@NgayDat", NgayDat.ToString());

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
        public void DanhSachDonHang()
        {
            string queryString =
            "SELECT * From DatHang";


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
                            reader[0], reader[1], reader[2], reader[3]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void DatHang(string MSDH, string MSHH, int soLuong, int tiLeGiam)
        {
            string queryString =
            "INSERT INTO DatHang(MSDH,MSHH,SoLuong,TiLeGiam)" +
            "VALUES(@MSDH, @MSHH, @soLuong, @tiLeGiam)";

            // Specify the parameter value.

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MSDH", MSDH);
                command.Parameters.AddWithValue("@MSHH", MSHH);
                command.Parameters.AddWithValue("@soLuong", soLuong);
                command.Parameters.AddWithValue("@tiLeGiam", tiLeGiam);

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
