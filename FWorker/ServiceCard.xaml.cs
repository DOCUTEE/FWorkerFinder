using System;
using System.IO;
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
using System.Reflection;

namespace FWorker
{
    /// <summary>
    /// Interaction logic for UCService.xaml
    /// </summary>
    public partial class ServiceCard : UserControl
    {
        string cardName;

        public string CardName { get => cardName; set => cardName = value; }

        public ServiceCard(string FileName, string cardName)
        {
            InitializeComponent();
            //assign folder contain application + path to imgService.Source
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\Picture\\" + FileName + ".png";
            imgService.Source = new BitmapImage(new Uri(path2));
            lblService.Content = cardName;
        } 
        public ServiceCard()
        {
            InitializeComponent();
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\Picture\\ServiceCard1.png";
            imgService.Source = new BitmapImage(new Uri(path2));
        }
        private void borderServiceCard_MouseEnter(object sender, MouseEventArgs e)
        {
            borderServiceCard.BorderThickness = new Thickness(3);
            borderServiceCard.BorderBrush = (SolidColorBrush) new BrushConverter().ConvertFrom("#FFBE22");
        }
        private void borderServiceCard_MouseLeave(object sender, MouseEventArgs e)
        {
            borderServiceCard.BorderThickness = new Thickness(0);
            borderServiceCard.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#00000000");
        }

        private void borderServiceCard_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            Grid mainContainer = (Grid)mainWindow.FindName("gridContext");
            mainContainer.Children.Clear();
            Frame frame = new Frame();
            frame.Content = new WorkerList();
            mainContainer.Children.Add(frame);
        }
    }
}
