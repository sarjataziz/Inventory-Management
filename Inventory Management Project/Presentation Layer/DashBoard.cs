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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory();

            manageCategory.Show();
            this.Hide();
        }

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProducts manageProducts = new ManageProducts();

            manageProducts.Show();
            this.Hide();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginFrom loginFrom = new LoginFrom();

            loginFrom.Show();
            this.Hide();
        }
    }
}
