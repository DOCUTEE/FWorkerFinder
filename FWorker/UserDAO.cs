using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FWorker.Properties;



namespace FWorker
{
    internal abstract class UserDAO
    {
        protected string tableName;
        protected DBConnection dbConn;

        public UserDAO()
        {
        }

        public UserDAO(string tableName)
        {
            this.tableName = tableName;
            this.dbConn = new DBConnection(Properties.Settings.Default.connStr);
        }


        public string TableName { get => tableName; set => tableName = value; }
        public DBConnection DbConn { get => dbConn; set => dbConn = value; }

        public abstract void Add(string tableName, User user);
        public abstract void Edit(string tableName, User user);




    }
}
