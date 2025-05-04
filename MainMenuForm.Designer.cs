namespace DM2coursework
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCustomerSignup = new System.Windows.Forms.Button();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.btnSupplierSignup = new System.Windows.Forms.Button();
            this.btnSupplierLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerSignup
            // 
            this.btnCustomerSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomerSignup.Location = new System.Drawing.Point(88, 70);
            this.btnCustomerSignup.Name = "btnCustomerSignup";
            this.btnCustomerSignup.Size = new System.Drawing.Size(300, 150);
            this.btnCustomerSignup.TabIndex = 0;
            this.btnCustomerSignup.Text = "Customer Signup";
            this.btnCustomerSignup.UseVisualStyleBackColor = false;
            this.btnCustomerSignup.Click += new System.EventHandler(this.btnCustomerSignup_Click);
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnCustomerLogin.Location = new System.Drawing.Point(88, 242);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(300, 150);
            this.btnCustomerLogin.TabIndex = 1;
            this.btnCustomerLogin.Text = "Customer Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = false;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // btnSupplierSignup
            // 
            this.btnSupplierSignup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupplierSignup.Location = new System.Drawing.Point(394, 70);
            this.btnSupplierSignup.Name = "btnSupplierSignup";
            this.btnSupplierSignup.Size = new System.Drawing.Size(300, 150);
            this.btnSupplierSignup.TabIndex = 2;
            this.btnSupplierSignup.Text = "Supplier Signup";
            this.btnSupplierSignup.UseVisualStyleBackColor = false;
            this.btnSupplierSignup.Click += new System.EventHandler(this.btnSupplierSignup_Click);
            // 
            // btnSupplierLogin
            // 
            this.btnSupplierLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnSupplierLogin.Location = new System.Drawing.Point(395, 241);
            this.btnSupplierLogin.Name = "btnSupplierLogin";
            this.btnSupplierLogin.Size = new System.Drawing.Size(300, 150);
            this.btnSupplierLogin.TabIndex = 3;
            this.btnSupplierLogin.Text = "Supplier Login";
            this.btnSupplierLogin.UseVisualStyleBackColor = false;
            this.btnSupplierLogin.Click += new System.EventHandler(this.btnSupplierLogin_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupplierLogin);
            this.Controls.Add(this.btnSupplierSignup);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.btnCustomerSignup);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerSignup;
        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.Button btnSupplierSignup;
        private System.Windows.Forms.Button btnSupplierLogin;
    }
}