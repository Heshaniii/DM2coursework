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
    public partial class CustomerSignupForm : Form
    {
        public CustomerSignupForm()
        {
            InitializeComponent();
            cpasswordBox.UseSystemPasswordChar = true;
        }

        private void CustomerSignupForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private readonly AuthService auth = new AuthService();

        private async void csignupBtn_Click(object sender, EventArgs e)
        {
            string p_cName = cnameBox.Text;
            string p_cEmail = cemailBox.Text;
            string p_cRawPassword = cpasswordBox.Text;
            string p_cPhone = cphoneBox.Text;
            string p_cAddress = caddressBox.Text;

            if (string.IsNullOrWhiteSpace(p_cEmail) || string.IsNullOrWhiteSpace(p_cRawPassword))
            {
                MessageBox.Show("Email and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string p_cHashedPassword = Utils.HashPassword(p_cRawPassword);

                var result = await auth.SignupCustomer(p_cName, p_cEmail, p_cHashedPassword, p_cPhone, p_cAddress);

                if (result != null)
                {
                    resultLabel.Text = $"Signup successful! ID: {result}";
                    MessageBox.Show("Signup successful!\nYour Customer ID is:\n" + result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cnameBox.Clear();
                    cemailBox.Clear();
                    cpasswordBox.Clear();
                    cphoneBox.Clear();
                    caddressBox.Clear();
                }
                else
                {
                    resultLabel.Text = "Signup failed. Email may already be in use.";
                }
            }
            catch (Exception ex)
            {
                resultLabel.Text = "Error: " + ex.Message;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

