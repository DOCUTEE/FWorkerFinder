using System;
using System.Collections.Generic;
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
    /// Interaction logic for UCCustomer.xaml
    /// </summary>
    public partial class Account : Page
    {
        private Customer customer;
        private CustomerDAO customerDAO;
        public Account()
        {
            InitializeComponent();
            this.customerDAO = new CustomerDAO();
            this.customer = customerDAO.GetCustomer("2");
            lbId.Content = customer.Id;
            tbCitizenID.Text = customer.CitizenID;
            tbName.Text = customer.Name;
            tbBirth.Text = customer.Birth.ToString();
            tbGender.Text = customer.Gender;
            tbAddress.Text = customer.Address;
            tbEmail.Text = customer.Email;
            tbNumber.Text = customer.PhoneNumber;
            string path1 = Environment.CurrentDirectory;

            string path = Directory.GetParent(path1).Parent.Parent.FullName + "\\" + customer.Logo;
            imgCustomer.Source = new BitmapImage(new Uri(path));


        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {


        }

        private void ApplyJob_Click(object sender, RoutedEventArgs e)
        {

            //Worker worker = new Worker(
            //    this.customer.Id, this.customer.Name, this.customer.Gender, this.customer.Birth, 
            //    this.customer.PhoneNumber, this.customer.Address, this.customer.Email,
            //    this.customer.CitizenID, this.customer.Logo, 0, null, null, null, 0);


            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            Frame mainContainer = (Frame)mainWindow.FindName("gridContext");
            mainContainer.NavigationService.Navigate(new ApplyJob(this.customer.Id));
        }

        private void LikedWorks_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            Frame mainContain = (Frame)mainWindow.FindName("gridContext");
            mainContain.Content = new WorkerList("LikedWorkerList");
        }
    }
}