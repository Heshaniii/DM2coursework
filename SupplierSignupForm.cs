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
    public partial class SupplierSignupForm: Form
    {
        private readonly AuthService auth = new AuthService();
        public SupplierSignupForm()
        {
            InitializeComponent();
            spasswordBox.UseSystemPasswordChar = true;
        }

        private async void ssignupBtn_Click(object sender, EventArgs e)
        {
            string p_sName = snameBox.Text;
            string p_sEmail = semailBox.Text;
            string rawPassword = spasswordBox.Text;
            string p_sPhone = sphoneBox.Text;
            string p_sAddress = saddressBox.Text;

            if (string.IsNullOrWhiteSpace(p_sEmail) || string.IsNullOrWhiteSpace(rawPassword))
            {
                MessageBox.Show("Email and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string p_sHashedPassword = Utils.HashPassword(rawPassword);
                MessageBox.Show("Hashed Password: " + p_sHashedPassword); 


                var result = await auth.SignupSupplier(p_sName, p_sEmail, p_sHashedPassword, p_sPhone, p_sAddress);

                if (result != null)
                {
                    resultLabel.Text = $"Signup successful! ID: {result}";
                    MessageBox.Show("Signup successful!\nYour Supplier ID is:\n" + result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    snameBox.Clear();
                    semailBox.Clear();
                    spasswordBox.Clear();
                    sphoneBox.Clear();
                    saddressBox.Clear();
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
    }
}
