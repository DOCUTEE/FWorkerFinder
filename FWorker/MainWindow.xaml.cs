using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Grid ButtonContainer = (Grid)FindName("SIDE");
            for (int i = 1; i <= 6; i++)
            {
                
                ButtonSideBar buttonSideBar = new ButtonSideBar(TypeOfButton(i),ContentOfButton(i));
                Grid temp = new Grid();
                temp.HorizontalAlignment = HorizontalAlignment.Left;
                temp.VerticalAlignment = VerticalAlignment.Center;
                Grid.SetRow(temp, i-1);
                temp.Children.Add(buttonSideBar);
                ButtonContainer.Children.Add(temp);
            }
        }
        public String TypeOfButton(int index)
        {
            switch (index)
            {
                case 1:
                    return "HomeScreen";
                case 2:
                    return "Booking";
                case 3:
                    return "History";
                case 4:
                    return "Tips";
                case 5:
                    return "Account";
                case 6:
                    return "CustomerService";
                default:
                    return "HomeScreen";
            }
        }
        public String ContentOfButton(int index)
        {
            switch (index)
            {
                case 1:
                    return "Trang chủ";
                case 2:
                    return "Đặt lịch";
                case 3:
                    return "Lịch sử";
                case 4:
                    return "Mẹo Hay";
                case 5:
                    return "Tài khoản";
                case 6:
                    return "Chăm sóc khách hàng";
                default:
                    return "Trang chủ";
            }
        }   
    }
}