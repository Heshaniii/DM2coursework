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
    public partial class SupplierLoginForm: Form
    {
        public SupplierLoginForm()
        {
            InitializeComponent();
            spasswordBox.UseSystemPasswordChar = true; 
        }

        private readonly AuthService auth = new AuthService();

        private async void sloginButton_Click(object sender, EventArgs e)
        {
            string p_sEmail = semailBox.Text;
            string rawPassword = spasswordBox.Text;

            if (string.IsNullOrWhiteSpace(p_sEmail) || string.IsNullOrWhiteSpace(rawPassword))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string p_sPassword = Utils.HashPassword(rawPassword); 

                var result = await auth.LoginSupplier(p_sEmail, p_sPassword);

                if (result != null)
                {
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var home = new SupplierHomepageForm(result);
                    home.Show();
                    this.Hide();
                }
                else
                {
                    sresultLabel.Text = "Login failed. Please check your credentials.";
                }
            }
            catch (Exception ex)
            {
                sresultLabel.Text = "Error: " + ex.Message;
            }
        }
    }
}
