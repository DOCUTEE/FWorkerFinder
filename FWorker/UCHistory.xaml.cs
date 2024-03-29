using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FWorker.Properties;

namespace FWorker
{
    /// <summary>
    /// Interaction logic for UCHistory.xaml
    /// </summary>
    public partial class UCHistory : UserControl
    {
        private int id = 1;
        public UCHistory(int id)
        {
            InitializeComponent();

            this.id = id;

            DBConnection dbConn = new DBConnection(Properties.Settings.Default.connStr);

            SqlDataReader a = dbConn.GetReader("SELECT request FROM WORKS WHERE worksID =" + this.id);
            a.Read();
            comment.Text = a.GetString(0);
            dbConn.Conn.Close();

            SqlDataReader b = dbConn.GetReader("SELECT name from WORKS WHERE worksID=" + this.id);
            b.Read();
            workerName.Text = b.GetString(0);
            dbConn.Conn.Close();
           
            SqlDataReader c = dbConn.GetReader("SELECT problemImage FROM WORKS WHERE worksID=" + this.id);
            c.Read();
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\" + c.GetString(0);
            workImage.Source = new BitmapImage(new Uri(path2));
            
            dbConn.Conn.Close();         
        }
    }
}
