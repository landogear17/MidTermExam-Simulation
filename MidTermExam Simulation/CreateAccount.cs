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

        
        public List<string> quebecCities = new List<string>() { "Montreal", "Quebec", "Gatineau", "Sherbrooke" };
        public List<string> ontarioCities = new List<string>() { "Toronto", "Ottawa", "Brampton", "Hamilton", "Windsor" };
        public List<string> albertaCities = new List<string>() { "Calgary", "Edmonton", "Red Deer" };

        public CreateAccount(List<Client>clientList, Form f1)
        {
            f1.Close();
            InitializeComponent();
            this.clientList = clientList;
            
        }

        private void bttnCreate_Click(object sender, EventArgs e)
        {
            Client client = new Client();

            if (txtBoxName.Text != "" && txtBoxEmail.Text != "" && txtBoxBirthdate.Text != "" && txtBoxUsername.Text != "" && txtBoxPassword.Text != "" && txtBoxStreetNumber.Text != "" && txtBoxStreetName.Text != "" && txtBoxPostalCode.Text != "")
            {
                
                client.Name = txtBoxName.Text;
                client.Birthdate = txtBoxBirthdate.Text;
                client.Email = txtBoxEmail.Text;
                client.Password = txtBoxPassword.Text;
                Address ad = new Address();
                ad.Street = txtBoxStreetName.Text;
                ad.PostalCode = txtBoxPostalCode.Text;
                ad.City = checkedListBoxCity.Text;
                ad.Province = checkedListBoxProvince.Text;

                if (txtBoxStreetNumber.Text != "")
                   ad.StreetNumber = Convert.ToInt32(txtBoxStreetNumber.Text);
                else
                    MessageBox.Show("Write a valid Text");
                client.Address = ad;


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
            else
                MessageBox.Show("There are empty fields");
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

        private void checkedListBoxProvince_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            checkedListBoxCity.Items.Clear();
            List<string> provinceList = new List<string>();


            switch (checkedListBoxProvince.SelectedIndex)
            {
                case 0:

                    provinceList = quebecCities;
                    
                    break;
                case 1:
                    //checkedListBoxCity.Items.Clear();
                    provinceList = ontarioCities;
                    
                    break;
                case 2:
                    //checkedListBoxCity.Items.Clear();
                    
                    provinceList = albertaCities;
                    break;
            }

            foreach (string province in provinceList)
            {
                checkedListBoxCity.Items.Add(province);
            }

            checkedListBoxProvince.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            checkedListBoxProvince.Enabled = true;
            
        }

        private void bttnBackLogin_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1(clientList);
            form1.Show();
            this.Close();
        }
    }
}
