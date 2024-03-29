using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for History.xaml
    /// </summary>
    public partial class History : Page
    {
        public History()
        {
            InitializeComponent();
            Grid historyContainer = (Grid)FindName("HistoryContainer");

            Grid temp = new Grid();
            Grid.SetRow(temp, 0);
            UCHistory uCHistory = new UCHistory(1);
            temp.Children.Add(uCHistory);
            historyContainer.Children.Add(temp);

            Grid temp1 = new Grid();
            Grid.SetRow(temp1, 1);
            UCHistory uCHistory1 = new UCHistory(1);
            temp1.Children.Add(uCHistory1);
            historyContainer.Children.Add(temp1);

            Grid temp2 = new Grid();
            Grid.SetRow(temp2, 2);
            UCHistory uCHistory2 = new UCHistory(1);
            temp2.Children.Add(uCHistory2);
            historyContainer.Children.Add(temp2);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
    }
}
