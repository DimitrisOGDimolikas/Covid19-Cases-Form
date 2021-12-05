using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid_19
{
    class Krousma
    {
        private String fullName;
        private String mail;
        private String phoneNumber;
        private String gender;
        private int age;
        private String nosima;
        private String address;
        private String timestamp;

        public Krousma(string fullName, string mail, string phoneNumber, string gender, int age, string address, string timestamp, string nosima = "")
        {
            this.FullName = fullName;
            this.Mail = mail;
            this.PhoneNumber = phoneNumber;
            this.Gender = gender;
            this.Age = age;
            this.Nosima = nosima;
            this.Address = address;
            this.Timestamp = timestamp;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string Mail { get => mail; set => mail = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Nosima { get => nosima; set => nosima = value; }
        public string Address { get => address; set => address = value; }
        public string Timestamp { get => timestamp; set => timestamp = value; }
    }
}
