using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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
    /// Interaction logic for Tips.xaml
    /// </summary>
    public partial class Tips : Page
    {
        public Tips()
        {
            InitializeComponent();
            string n1 = "Quốc Thịnh";
            string j1 = "Leader";
            string av1 = "C:\\Users\\ADMIN\\Documents\\HK2\\LTWin\\FWorkerFinder\\FWorker\\Image\\Thinh.jpg";

            string n2 = "Minh Quang";
            string j2 = "Intern";
            string av2 = "C:\\Users\\ADMIN\\Documents\\HK2\\LTWin\\FWorkerFinder\\FWorker\\Image\\Quang.jpg";

            string n3 = "Quốc Huy";
            string j3 = "Intern";
            string av3 = "C:\\Users\\ADMIN\\Documents\\HK2\\LTWin\\FWorkerFinder\\FWorker\\Image\\Huy.jpg";

            textBlockName1.Text = n1;
            textBlockJob1.Text = j1;
            ava1.Source = new BitmapImage(new Uri(av1));

            textBlockName2.Text = n2;
            textBlockJob2.Text = j2;
            ava2.Source = new BitmapImage(new Uri(av2));

            textBlockName3.Text = n3;
            textBlockJob3.Text = j3;
            ava3.Source = new BitmapImage(new Uri(av3));
        }
    }
}
