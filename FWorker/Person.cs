using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWorker
{
    class Person
    {
        private string fullName;
        private string gender;
        private string address;
        private string phoneNumber;
        private string email;
        private DateTime dateOfBirth;
        public Person()
        {

        }
        public Person(string fullName, string gender, string address, string phoneNumber, string email, DateTime dateOfBirth)
        {
            this.FullName = fullName;
            this.Gender = gender;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.DateOfBirth = dateOfBirth;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}
