using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM2coursework
{
    public partial class CustomerHomepageForm: Form
    {
        private readonly string customerId;

        public CustomerHomepageForm(string customerID)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerHomepageForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome, Customer!\nYour ID: {customerId}";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart(); 
        }
    }
}
