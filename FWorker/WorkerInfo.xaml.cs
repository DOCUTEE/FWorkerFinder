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
    /// Interaction logic for WorkerInfo.xaml
    /// </summary>
    public partial class WorkerInfo : Page
    {
        public WorkerInfo()
        {
            InitializeComponent();
        }

    

       

        private void btnInfo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Hidden;
            containerInfo.Visibility = Visibility.Visible;
        }

        private void btnDescription_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            containerDescription.Visibility = Visibility.Visible;
            containerDescription.Visibility = Visibility.Hidden;
        }
    }
}
