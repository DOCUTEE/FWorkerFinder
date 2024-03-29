using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWorker
{
    class LikedWorker
    {
        string customerID;
        string workerID;

        public string CustomerID { get => customerID; set => customerID = value; }
        public string WorkerID { get => workerID; set => workerID = value; }

        LikedWorker() { }
        public LikedWorker(string customerID, string workerID)
        {
            this.CustomerID = customerID;
            this.WorkerID = workerID;
        }
        public LikedWorker(string workerID)
        {
            this.customerID = "1";
            this.workerID = workerID;
        }
    }
}
