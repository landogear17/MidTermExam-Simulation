using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTermExam_Simulation
{
    public partial class Form1 : Form
    {
        
        private List<Client> clientList = new List<Client>();
        
        public Form1()
        {
            InitializeComponent();
            //date = new DateTime(1997, 06, 14);
            Client client1 = new Client(1, "Anthony", "anthonylf797@gmail.com","14/06/1997","landogear", "chacalito");
            //date = new DateTime(1997, 09, 17);
            Client client2 = new Client(2, "Sergio", "sergio.aqs@gmail.com", "17/09/1997","zerocomes", "cpp");
            clientList.Add(client1);
            clientList.Add(client2);
        }
        public Form1(List<Client> clientList)
        {
            InitializeComponent();
            this.clientList = clientList;
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            
            if (isValidMember(username, password))
                MessageBox.Show("Accepted");
            else
            {
                MessageBox.Show("Wrong Credentials");
                txtBoxUsername.Clear();
                txtBoxPassword.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formCreateAccount = new CreateAccount(clientList,this);        
            formCreateAccount.Show();
            this.Hide();
        }
        
        /*
        private void validMember(string username, string password)
        {

            int cont = 0;
            foreach (Client client in clientList)
            {
                if (username == client.Username && password == client.Password)
                {
                    MessageBox.Show("Accepted");
                }
                if (username == client.Username && password != client.Password)
                {
                    MessageBox.Show("Wrong password, Try Again");
                    txtBoxPassword.Clear();
                }
                if (cont > clientList.Count-1)
                {
                    MessageBox.Show("Wrong Credentials, Try Again");
                    txtBoxUsername.Clear();
                    txtBoxPassword.Clear();
                }
                cont++;
            }
            cont = 0;
        }
        */

        private bool isValidMember(string username, string password)
        {
            foreach (Client client in clientList)            
                if (username == client.Username && password == client.Password)
                    return true;
            return false;
        }

    }
}
