using System;
using System.Collections.Generic;
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
using System.IO;


namespace FWorker
{
    /// <summary>
    /// Interaction logic for UCWorker.xaml
    /// </summary>
    public partial class ApplyJob : Page
    {
        private Worker worker;
        
        public ApplyJob(Worker worker)
        {
            InitializeComponent();
            this.worker = worker;
            tbCitizenID.Text = worker.CitizenID;
            tbName.Text = worker.Name;
            tbGender.Text = worker.Gender;
            tbBirth.Text = worker.Name.ToString();
            tbAddress.Text = worker.Address;
            tbEmail.Text = worker.Email;
            tbNumber.Text = worker.PhoneNumber;

            string path1 = Environment.CurrentDirectory;

            string path = Directory.GetParent(path1).Parent.Parent.FullName + "\\" + worker.Logo;
            imgWorker.Source = new BitmapImage(new Uri(path));

        }
    }
}
