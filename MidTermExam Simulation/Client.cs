using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam_Simulation
{
    public class Client
    {
        private bool flag; // To identified the current user connected.
        private double id;
        private string name;
        private string email;
        private DateTime birthdate;
        private string username;
        private string password;
        private Address address;
        public Client()
        {
            flag = false;
        }

        public Client(double id, string name, string email, DateTime birthdate, string username, string password)
        {
            flag = false;
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
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public Address Address { get => address; set => address = value; }
        public bool Flag { get => flag; set => flag = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
