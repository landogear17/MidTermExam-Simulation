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
    public partial class CreateAccount : Form
    {
        public List<Client> clientList = new List<Client>();
        public CreateAccount(List<Client>clientList)
        {
            InitializeComponent();
            this.clientList = clientList;
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Name = txtBoxName.Text;
            client.Birthdate = txtBoxBirthdate.Text;
            client.Email = txtBoxEmail.Text;
            client.Password = txtBoxPassword.Text;
            if (isUsernameExist(txtBoxUsername.Text))
            {
                MessageBox.Show("The Username is already used");
                txtBoxUsername.Clear();
            }
            else
            {
                client.Username = txtBoxUsername.Text;
                MessageBox.Show("Creation Complete");
                clientList.Add(client);
                Form form1 = new Form1(clientList);
                form1.Show();
                this.Close();
            }
            
        }
       
        private double getNextId()
        {
            double id;
            Client lastClient = clientList.Last<Client>();
            id = lastClient.Id;
            id = id+1;
            
            return id;
        }
        private bool isUsernameExist(string username)
        {
            foreach (Client client in clientList)
                if (username == client.Username)
                    return true;
            return false;
        }
    }
}
