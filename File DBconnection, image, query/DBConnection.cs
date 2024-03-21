using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;

namespace FWorker
{
    internal class DBConnection
    {
        // This is a class that is used to connect to the database
        SqlConnection conn;
        // Sqlconnection not found 
        public DBConnection()
        {
        }
        public DBConnection(string connStr)
        {
            conn = new SqlConnection(connStr);
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
        public DataTable AdapterExecute(string sqlStr)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dataTable);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        public DataTable LoadData(string tableName)
        {
            string sqlStr = string.Format("SELECT * FROM {0}", tableName);
            DataTable dataTable = AdapterExecute(sqlStr);
            return dataTable;
        }
    }
}
