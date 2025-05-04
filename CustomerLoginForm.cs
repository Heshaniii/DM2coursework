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
    public partial class CustomerLoginForm : Form
    {
        private readonly AuthService auth = new AuthService();

        public CustomerLoginForm()
        {
            InitializeComponent();
            cpasswordBox.UseSystemPasswordChar = true; 
        }

        private async void cloginButton_Click(object sender, EventArgs e)
        {
            string p_cEmail = cemailBox.Text;
            string rawPassword = cpasswordBox.Text;

            if (string.IsNullOrWhiteSpace(p_cEmail) || string.IsNullOrWhiteSpace(rawPassword))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string p_cPassword = Utils.HashPassword(rawPassword); 

                var result = await auth.LoginCustomer(p_cEmail, p_cPassword);

                if (result != null)
                {
                    MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var home = new CustomerHomepageForm(result); 
                    home.Show();
                    this.Hide();
                }
                else
                {
                    resultLabel.Text = "Login failed. Check your credentials.";
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Error: " + ex.Message;
            }
        }

        private void CustomerLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
