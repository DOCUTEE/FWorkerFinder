using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FWorker
{
    internal class DBConnection
    {
        SqlConnection conn;

        public DBConnection(string connStr)
        {
            conn = new SqlConnection(connStr);
        }

        public DataTable LoadData(string tableName)
        {
            DataTable dtTable = new DataTable();

            try
            {
                conn.Open();
                string sqlStr = $"SELECT * FROM {tableName}";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dtTable;
        }


        public void CommandExecute(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
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
                conn.Close();
            }
        }

        public SqlDataReader GetReader(string sqlStr, SqlParameter parameter)
        {
            // Tạo một đối tượng SqlCommand để thực thi câu truy vấn
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            // Thêm tham số vào đối tượng SqlCommand
            cmd.Parameters.Add(parameter);

            // Thực thi câu truy vấn và trả về SqlDataReader
            return cmd.ExecuteReader();
        }

        public void AdapterExecute(string sqlStr, string successMessage)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
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
                conn.Close();
            }
        }
    }
}
