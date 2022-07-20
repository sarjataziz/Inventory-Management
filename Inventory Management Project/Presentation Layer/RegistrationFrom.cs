using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Management_Project.Data_Access_Layer;

namespace Inventory_Management_Project.Presentation_Layer
{
    public partial class RegistrationFrom : Form
    {
        public RegistrationFrom()
        {
            InitializeComponent();
        }

        public string ConfigarationManager { get; private set; }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void submitButton1_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text == "")
            {
                MessageBox.Show("   Name can not be empty.  ");                                       //Show the message
            }
            else if (userNameTextBox.Text == "")
            {
                MessageBox.Show("   Userame can not be empty.  ");                                       //Show the message
            }
            if (emailTextBox.Text == "")
            {
                MessageBox.Show("   Email can not be empty.  ");                                       //Show the message
            }
            if (passwordTextBox.Text == "")
            {
                MessageBox.Show("   Password can not be empty.  ");                                       //Show the message
            }
            if (confirmPasswordTextBox.Text == "")
            {
                MessageBox.Show("   Confirm Password can not be empty.  ");                                       //Show the message
            }
            if (dateOfBirthDatePicker.Value.Date.ToString() == DateTime.Now.Date.ToString())
            {
                MessageBox.Show("   Date of Birth incorrect.  ");                                       //Show the message
            }
            if ((genderRadioButton1.Checked == false) && (genderRadioButton2.Checked == false))
            {
                MessageBox.Show("   Select gender.  ");                                       //Show the message
            }
            if (bloodGroupComboBox.Text == "")
            {
                MessageBox.Show("   Blood Group can not be empty.  ");                                       //Show the message
            }
            else
            {
                if(passwordTextBox.Text != confirmPasswordTextBox.Text)
                {
                    MessageBox.Show("Password doesn't match.");
                }
                else
                {
                    User user = new User();

                    user.Name = nameTextBox.Text;
                    user.Username = userNameTextBox.Text;
                    user.Email = emailTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.DateOfBirth = dateOfBirthDatePicker.Text;
                    if(genderRadioButton1.Checked)
                    {
                        user.Gender = "Male";
                    }
                    else
                    {
                        user.Gender = "Female";
                    }
                    user.BloodGroup = bloodGroupComboBox.Text;

                    UserDataAccess userDataAccess = new UserDataAccess();   

                    bool result = userDataAccess.Registration(user.Name, user.Username, user.Email, user.Password, user.DateOfBirth, user.Gender, user.BloodGroup);

                    if(result)
                    {
                        MessageBox.Show("User added successfully.");

                        LoginFrom loginFrom = new LoginFrom();
                        loginFrom.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error in registration.");
                    }
                }
            }
        }

        private void termsheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(termscheckBox.Checked)
            {
                submitButton1.Enabled = true;
            }
            else
            { 
                submitButton1.Enabled = false;
            }
        }

        private void BackRegistrationButton_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();

            loginFrom.Show();
            this.Hide();
        }
    }
}
