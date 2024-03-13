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
    /// Interaction logic for UCService.xaml
    /// </summary>
    public partial class UCService : UserControl
    {
        string path;

        public string Path { get => path; set => path = value; }

        public UCService(string path)
        {
            InitializeComponent();
            this.Path = path;
        }
        public UCService()
        {
            InitializeComponent();
        }
    }
}
