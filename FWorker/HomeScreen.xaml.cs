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
    /// Interaction logic for HomeScreen.xaml
    /// </summary>
    public partial class HomeScreen : Page
    {
        public HomeScreen()
        {
            InitializeComponent();
            // get grid ServiceContainer
            Grid ServiceContainer = (Grid)FindName("ServiceContainer");
            for(int i = 0; i < 10; i++)
            {
                //add new grid have Grid.Row = i/2, Grid.Column = i %5 to ServiceContainer
                Grid temp = new Grid();
                ServiceCard serviceCard = new ServiceCard("ServiceCard" + (i+1).ToString(),TypeOfService(i));
                temp.Children.Add(serviceCard);
                Grid.SetRow(temp, i / 5);
                Grid.SetColumn(temp, i % 5);
                ServiceContainer.Children.Add(temp);
            }
        }
        public String TypeOfService(int index)
        {
            //swithcase
            switch (index)
            {
                case 0:
                    return "Service 1";
                case 1:
                    return "Service 2";
                case 2:
                    return "Service 3";
                case 3:
                    return "Service 4";
                case 4:
                    return "Service 5";
                case 5:
                    return "Service 6";
                case 6:
                    return "Service 7";
                case 7:
                    return "Service 8";
                case 8:
                    return "Service 9";
                case 9:
                    return "Service 10";
                default:
                    return "Service";
            }   
        }

        

        //write a function to show 10 services option in 10 part of ServiceContainer Grid
        private void ShowServices()
        {
            
        }
        private void ButtonShowMore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ServiceCard1_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}


