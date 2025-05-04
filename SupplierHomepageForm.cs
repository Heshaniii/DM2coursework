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
    public partial class SupplierHomepageForm: Form
    {
        private readonly string supplierId;
        public SupplierHomepageForm(string supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
        }

        private void SupplierHomepageForm_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome, Supplier!\nYour ID: {supplierId}";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart(); 
        }
    }
}
