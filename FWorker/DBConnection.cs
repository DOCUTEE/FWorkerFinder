using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace FWorker
{
    public class DBConnection
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
