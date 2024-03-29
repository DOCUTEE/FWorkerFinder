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

namespace FWorker
{
    /// <summary>
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Page
    {

        public Booking()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Works works = new Works(0, txtCustomerName.Text, txtPhoneNumber.Text, txtAddress.Text, txtProblem.Text, "");
            WorksDAO worksDAO = new WorksDAO();
            worksDAO.Add("WORKS", works);
        }
    }
}

