using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWorker
{
    class Worker: Person
    {
        private string workerId;
        private double rating;

        public Worker()
        {

        }
        public Worker(string workerId, double rating)
        {
            this.workerId = workerId;
            this.rating = rating;
        }   

    }
}
