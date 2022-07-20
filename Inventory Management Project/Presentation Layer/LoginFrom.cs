using Inventory_Management_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_Project.Presentation_Layer
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void LoginFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
             UserDataAccess userDataAccess = new UserDataAccess();

            if(UsernameTextBox.Text == "")
            {
                MessageBox.Show("Username is empty.");
            }
            else if(PasswordTextBox.Text == "")
            {
                MessageBox.Show("Username is empty.");
            }
            else
            {
                if (userDataAccess.LoginValidation(UsernameTextBox.Text, PasswordTextBox.Text))
                {
                    DashBoard dashBoard = new DashBoard();
                    dashBoard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.");
                }
            }          
        }

        private void NewUserLinkLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationFrom registrationFrom = new RegistrationFrom();

            registrationFrom.Show();
            this.Hide();
        }
    }
}
