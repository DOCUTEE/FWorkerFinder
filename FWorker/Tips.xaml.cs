using System;
using System.Collections.Generic;
using System.IO;
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
            string path = Environment.CurrentDirectory;
            string thinh = Directory.GetParent(path).Parent.Parent.FullName + "\\Picture\\" + "ServiceCard1.png";

            string n2 = "Minh Quang";
            string j2 = "Intern";
            string quang = Directory.GetParent(path).Parent.Parent.FullName + "\\Picture\\" + "ServiceCard2.png";

            string n3 = "Quốc Huy";
            string j3 = "Intern";
            string huy = Directory.GetParent(path).Parent.Parent.FullName + "\\Picture\\" + "ServiceCard3.png";

            textBlockName1.Text = n1;
            textBlockJob1.Text = j1;
            ava1.Source = new BitmapImage(new Uri(thinh));

            textBlockName2.Text = n2;
            textBlockJob2.Text = j2;
            ava2.Source = new BitmapImage(new Uri(quang));

            textBlockName3.Text = n3;
            textBlockJob3.Text = j3;
            ava3.Source = new BitmapImage(new Uri(huy));
        }
    }
}
