using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.Data;
using FWorker.Properties;

namespace FWorker
{
    internal class WorksDAO
    {
        private string tableName;
        private DBConnection dbConn;

      
        public WorksDAO()
        {
            this.tableName = "WORKS";
            this.dbConn = new DBConnection(Properties.Settings.Default.connStr);
        }
        protected string TableName { get => tableName; set => tableName = value; }
        protected DBConnection DbConn { get => dbConn; set => dbConn = value; }
        
        public void Add(string tableName, Works works)
        {
            string sqlStr;
                sqlStr = $"INSERT INTO WORKS (name, number, locate,request,problemImage) VALUES('{works.Name}','{works.Number}','{works.Locate}','{works.Request}','{works.ProblemImage}')";
            dbConn.CommandExecute(sqlStr);
            
        }
    }
}
