using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FWorker
{
    public class User
    {
        protected string id;
        protected string name;
        protected string gender;
        protected DateTime birth;
        protected string phoneNumber;
        protected string address;
        protected string email;
        protected string citizenID;
        protected string logo;

        public User(string id, string name, string gender, DateTime birth, string phoneNumber, string address, string email, string citizenID, string logo)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.birth = birth;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.email = email;
            this.citizenID = citizenID;
            this.logo = logo;
        }

        public User() { }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string Logo { get => logo; set => logo = value; }

        //protected User() { }



    }


}
