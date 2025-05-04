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
    public partial class MainMenuForm: Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerSignup_Click(object sender, EventArgs e)
        {
            new CustomerSignupForm().Show();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            new CustomerLoginForm().Show();
        }

        private void btnSupplierSignup_Click(object sender, EventArgs e)
        {
            new SupplierSignupForm().Show();
        }

        private void btnSupplierLogin_Click(object sender, EventArgs e)
        {
            new SupplierLoginForm().Show();
        }
    }
}
