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
    /// Interaction logic for WorkerButton.xaml
    /// </summary>
    public partial class WorkerButton : UserControl
    {
        Worker worker;
        public WorkerButton(Worker worker)
        {
            this.worker = worker;
            
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + worker.Logo;
            imgWorker.Source = new BitmapImage(new Uri(path2));
            workerName.Content = worker.Name;
            string tmp = worker.Rating.ToString();
            string ratingStr = "Đánh giá: " + tmp + "/5⭐";
            workerRating.Content = ratingStr;
            workerAddress.Text = "Địa chỉ: " + worker.Address;
            lblPhoneNumber.Content = worker.PhoneNumber;



        }
        public WorkerButton()
        {
            InitializeComponent();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void borderWorker_MouseEnter(object sender, MouseEventArgs e)
        {
            borderWorker.BorderThickness = new Thickness(3);
            borderWorker.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFBE22");
        }

        private void borderWorker_MouseLeave(object sender, MouseEventArgs e)
        {
            borderWorker.BorderThickness = new Thickness(0);
            borderWorker.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#00000000");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            Grid mainContainer = (Grid)mainWindow.FindName("gridContext");
            mainContainer.Children.Clear();
            Frame frame = new Frame();
            frame.Content = new WorkerInfo(worker);
            mainContainer.Children.Add(frame);
        }
    }
}
