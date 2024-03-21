using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FWorker
{
    public class Worker : User
    {
        private double rating ;
        private string description ;
        private string qualifications ;
        private string field ;
        private double pricePerHour;

        public Worker(string id, string name, string gender, DateTime birth, string phoneNumber, string address, string email, string citizenID, string logo, double rating, string description, string qualifications, string field, double pricePerHour) : base(id, name, gender, birth, phoneNumber, address, email, citizenID, logo)
        {
            this.rating = rating;
            this.description = description;
            this.qualifications = qualifications;
            this.field = field;
            this.pricePerHour = pricePerHour;
        }

        public Worker() { }
        public double Rating { get => rating; set => rating = value; }
        public string Description { get => description; set => description = value; }
        public string Qualifications { get => qualifications; set => qualifications = value; }
        public string Field { get => field; set => field = value; }
        public double PricePerHour { get => pricePerHour; set => pricePerHour = value; }

        public bool ValidateData()
        {
            return true;
        }

    }
}
