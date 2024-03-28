using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using System.Data.SqlClient;
using System.Data;

namespace FWorker
{
    class LikedWorkerDAO
    {
        private string tableName;
        private DBConnection dbConn;
        public LikedWorkerDAO()
        {
            this.TableName = "LikedWorker";
            this.DbConn = new DBConnection(Properties.Settings.Default.connStr);
        }

        public string TableName { get => tableName; set => tableName = value; }
        internal DBConnection DbConn { get => dbConn; set => dbConn = value; }
        public void Add(LikedWorker likedWorker)
        {
            string sqlStr = $"insert into {this.tableName} values ('{likedWorker.CustomerID}','{likedWorker.WorkerID}')";
            dbConn.CommandExecute(sqlStr);
        }
        public void Remove(LikedWorker likedWorker)
        {
            string sqlStr = $"Delete from {tableName} where CustomerID = '{likedWorker.CustomerID}' and WorkerID = '{likedWorker.WorkerID}'";
            dbConn.CommandExecute(sqlStr);
        }
        public void Add(string WorkerID)
        {
            string sqlStr = $"insert into {this.tableName} values ('1','{WorkerID}')";
            dbConn.CommandExecute(sqlStr);
        }
        public void Remove(string WorkerID)
        {
            string sqlStr = $"Delete from {this.tableName} where CustomerID = '1' and WorkerID = '{WorkerID}'";
            dbConn.CommandExecute(sqlStr);
        }
        public bool IsExisting(string CustomerID, string WorkerID) 
        {
            
            string sqlStr = $"Select * from {tableName} where CustomerID = '{CustomerID}' and WorkerID = '{WorkerID}'";
            SqlDataReader reader = dbConn.GetReader(sqlStr);
            return reader.HasRows;
        }
    }
}
