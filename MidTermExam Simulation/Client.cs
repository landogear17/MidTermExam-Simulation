using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam_Simulation
{
    public class Client
    {
        private double id;
        private string name;
        private string email;
        private string birthdate;
        private string username;
        private string password;
        private Address address;
        public Client()
        {
        }

        public Client(double id, string name, string email, string birthdate, string username, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthdate = birthdate;
            this.username = username;
            this.password = password;
        }

        public double Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public Address Address { get => address; set => address = value; }
    }
}
