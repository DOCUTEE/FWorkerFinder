using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FWorker
{
    internal class DBConnection
    {
        SqlConnection conn;

        public SqlConnection Conn { get => conn; set => conn = value; }

        public DBConnection(string connStr)
        {
            Conn = new SqlConnection(connStr);
        }

        public DataTable LoadData(string tableName)
        {
            DataTable dtTable = new DataTable();

            try
            {
                Conn.Open();
                string sqlStr = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, Conn);
                adapter.Fill(dtTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return dtTable;
        }


        public void CommandExecute(string sqlStr)
        {
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, Conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Thất bại " + exc.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        public SqlDataReader GetReader(string sqlStr/*, SqlParameter parameter*/)
        {
            // Tạo một đối tượng SqlCommand để thực thi câu truy vấn
            SqlCommand cmd = new SqlCommand(sqlStr, Conn);
            // Thêm tham số vào đối tượng SqlCommand
            //cmd.Parameters.Add(parameter);

            // Mở kết nối trước khi thực thi câu truy vấn
            Conn.Open();

            // Thực thi câu truy vấn và trả về SqlDataReader
            return cmd.ExecuteReader();
        }

        public void AdapterExecute(string sqlStr, string successMessage)
        {
            try
            {
                Conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, Conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(successMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
