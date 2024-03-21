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
    /// Interaction logic for WorkerButton.xaml
    /// </summary>
    public partial class WorkerButton : UserControl
    {
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
            frame.Content = new WorkerInfo();
            mainContainer.Children.Add(frame);
        }
    }
}
