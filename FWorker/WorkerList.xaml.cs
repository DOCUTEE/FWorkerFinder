using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for WorkerList.xaml
    /// </summary>
    public partial class WorkerList : Page
    {
        private List<Worker> workers;
        public WorkerList(String cardName)
        {
            InitializeComponent();
            //List<Worker> workers;
            if (cardName != "LikedWorkerList")
            {
                WorkerDAO workerDAO = new WorkerDAO();
                this.workers = workerDAO.GetWorkerListService(cardName, 10); 
            }
            else
            {
                LikedWorkerDAO likedWorkerDAO = new LikedWorkerDAO();
                this.workers = likedWorkerDAO.GetLikedList("1");
            }
            this.AddWorkersToContainer("WorkerContainer",this.workers);
        }
        public WorkerList(List<Worker> workers)
        {
            InitializeComponent();
            
        }
        
        public WorkerList()
        {
            InitializeComponent();
            Grid Container = (Grid)FindName("WorkerContainer");
            
            for(int i = 0; i < 10; i++)
            {
                int x = i / 2;
                int y = i % 2;
                Grid temp = new Grid();
                Grid.SetRow(temp, x);
                Grid.SetColumn(temp, y);
                WorkerButton workerButton = new WorkerButton();
                temp.Children.Add(workerButton);
                Container.Children.Add(temp);
            }
        }

        void AddWorkersToContainer(string container, List<Worker>workers)
        {
            
            Grid contain = (Grid)FindName("WorkerContainer");
            for (int i = 0; i < this.workers.Count; i++)
            {
                int x = i / 2;
                int y = i % 2;
                Grid temp = new Grid();
                Grid.SetRow(temp, x);
                Grid.SetColumn(temp, y);
                WorkerButton workerButton = new WorkerButton(workers[i]);
                temp.Children.Add(workerButton);
                contain.Children.Add(temp);
            }
        }

        private void SortPrice_Click(object sender, RoutedEventArgs e)
        {
            
            var sortedWorker = workers.OrderBy(worker => worker.PricePerHour).ToList();
            AddWorkersToContainer("WorkerContainer", sortedWorker);
        }
    }
}
