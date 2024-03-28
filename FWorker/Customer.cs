using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWorker
{
    internal class Customer : User
    {
        public Customer(string id, string name, string gender, DateTime birth, string phoneNumber, string address, string email, string citizenID, string logo) : base(id, name, gender, birth, phoneNumber, address, email, citizenID, logo)
        { }


        public bool ValidateData()
        {
            return true;
        }
    }
}
