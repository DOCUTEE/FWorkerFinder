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
    /// Interaction logic for ButtonSideBar.xaml
    /// </summary>
    public partial class ButtonSideBar : UserControl
    {
        private String name;
        private String context;

        public string Name { get => name; set => name = value; }
        public string Context { get => context; set => context = value; }

        public ButtonSideBar(String name, String context)
        {
            InitializeComponent();
            this.name = name;
            this.context = context;
            
            string path = Environment.CurrentDirectory;
            string path2 = Directory.GetParent(path).Parent.Parent.FullName + "\\Logo\\" + name + ".png";
            imgSideButton.Source = new BitmapImage(new Uri(path2));
            lblContext.Content = context;
        }
        public ButtonSideBar()
        {
            this.name = "HomeScreen";
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        private void Navigate_Click(object sender, RoutedEventArgs e)
        {
            //get name of button
            string name =this.Name;
            //get main window
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            //get grid main container
            Frame mainContainer = (Frame)mainWindow.FindName("gridContext");
            //clear all children of main container
            //mainContainer.Children.Clear();
            //add new page to main container
            //Frame frame = new Frame();
            switch (name)
            {
                case "HomeScreen":
                    mainContainer.Content = new HomeScreen();

                    break;
                case "Booking":
                    mainContainer.Content = new Booking();
                    break;
                case "History":
                    mainContainer.Content = new History();
                    break;
                case "Tips":
                    mainContainer.Content = new Tips();
                    break;
                case "Account":
                    mainContainer.Content = new Account();
                    break;
                case "CustomerService":
                    mainContainer.Content = new CustomerService();
                    break;
                default:
                    mainContainer.Content = new HomeScreen();
                    break;
            }
            this.btnNavigate.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FFBE22");
            //mainContainer.Children.Add(frame);
        }

        
    }   
}
