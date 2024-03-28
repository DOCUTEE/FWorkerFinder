using System;
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

namespace FWorker
{
    /// <summary>
    /// Interaction logic for WorkerInfo.xaml
    /// </summary>
    public partial class WorkerInfo : Page
    {
        Worker worker;
        LikedWorkerDAO likedWorkerDAO = new LikedWorkerDAO();
        public WorkerInfo()
        {
            InitializeComponent();
        }
        public WorkerInfo(Worker worker)
        {
            this.worker = worker;
            List<String> location = ["Bình Định", "Huế", "Hà Nội", "Hồ Chí Minh", "Phú Yên"];
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName +"\\" + worker.Logo;
            imgWorker.Height = 180;
            imgWorker.Source = new BitmapImage(new Uri(path2));
            
            tblWorkerName.Text = worker.Name;
            Random random = new Random();
            tblWorkerLocation.Text = location[random.Next(0,4)];
            tblField.Text = worker.Field;
            string tmp = worker.Rating.ToString();
            tblRating.Text = tmp + "/5⭐";
            tblPhoneNumber.Text = worker.PhoneNumber;
            tblAddress.Text = worker.Address;
            tblEmail.Text = worker.Email;
            tblGender.Text = worker.Gender;
            tblBirth.Text = worker.Birth.ToString();
            tblDescription.Text = worker.Description;
            string bookmarkPath = Directory.GetParent(path).Parent.Parent.FullName + "\\Logo\\";
            if (likedWorkerDAO.IsExisting("1", this.worker.Id)) bookmarkPath += "HeartRed.png";
            else bookmarkPath += "HeartBlank.png";
            BookmarkIcon.Source = new BitmapImage(new Uri(bookmarkPath));
            likedWorkerDAO.DbConn.Conn.Close();
        }
        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Hidden;
            containerInfo.Visibility = Visibility.Visible;
        }

        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Visible;
            containerInfo.Visibility = Visibility.Hidden;
        }

        private void BookmarkIcon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string bookmarkPath = Directory.GetParent(path).Parent.Parent.FullName + "\\Logo\\";
            //MessageBox.Show("OKEEE");
            
            if (likedWorkerDAO.IsExisting("1", this.worker.Id))
            {
                likedWorkerDAO.DbConn.Conn.Close();
                likedWorkerDAO.Remove(this.worker.Id);
                bookmarkPath += "HeartBlank.png";

            }
            else
            {
                likedWorkerDAO.DbConn.Conn.Close();
                likedWorkerDAO.Add(this.worker.Id);
                bookmarkPath += "HeartRed.png";
            }
            BookmarkIcon.Source = new BitmapImage(new Uri(bookmarkPath));
        }
    }
}
