namespace DM2coursework
{
    partial class CustomerSignupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnameBox = new System.Windows.Forms.TextBox();
            this.cemailBox = new System.Windows.Forms.TextBox();
            this.cpasswordBox = new System.Windows.Forms.TextBox();
            this.cphoneBox = new System.Windows.Forms.TextBox();
            this.caddressBox = new System.Windows.Forms.TextBox();
            this.csignupBtn = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Address:";
            // 
            // cnameBox
            // 
            this.cnameBox.Location = new System.Drawing.Point(206, 46);
            this.cnameBox.Name = "cnameBox";
            this.cnameBox.Size = new System.Drawing.Size(500, 26);
            this.cnameBox.TabIndex = 5;
            // 
            // cemailBox
            // 
            this.cemailBox.Location = new System.Drawing.Point(207, 95);
            this.cemailBox.Name = "cemailBox";
            this.cemailBox.Size = new System.Drawing.Size(500, 26);
            this.cemailBox.TabIndex = 6;
            // 
            // cpasswordBox
            // 
            this.cpasswordBox.Location = new System.Drawing.Point(207, 152);
            this.cpasswordBox.Name = "cpasswordBox";
            this.cpasswordBox.Size = new System.Drawing.Size(500, 26);
            this.cpasswordBox.TabIndex = 7;
            // 
            // cphoneBox
            // 
            this.cphoneBox.Location = new System.Drawing.Point(206, 209);
            this.cphoneBox.Name = "cphoneBox";
            this.cphoneBox.Size = new System.Drawing.Size(500, 26);
            this.cphoneBox.TabIndex = 8;
            // 
            // caddressBox
            // 
            this.caddressBox.Location = new System.Drawing.Point(208, 268);
            this.caddressBox.Name = "caddressBox";
            this.caddressBox.Size = new System.Drawing.Size(500, 26);
            this.caddressBox.TabIndex = 9;
            // 
            // csignupBtn
            // 
            this.csignupBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.csignupBtn.Location = new System.Drawing.Point(285, 362);
            this.csignupBtn.Name = "csignupBtn";
            this.csignupBtn.Size = new System.Drawing.Size(200, 71);
            this.csignupBtn.TabIndex = 10;
            this.csignupBtn.Text = "Sign up";
            this.csignupBtn.UseVisualStyleBackColor = false;
            this.csignupBtn.Click += new System.EventHandler(this.csignupBtn_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(213, 317);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 11;
            // 
            // CustomerSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.csignupBtn);
            this.Controls.Add(this.caddressBox);
            this.Controls.Add(this.cphoneBox);
            this.Controls.Add(this.cpasswordBox);
            this.Controls.Add(this.cemailBox);
            this.Controls.Add(this.cnameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignupForm";
            this.Text = "Customer Signup Form";
            this.Load += new System.EventHandler(this.CustomerSignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cnameBox;
        private System.Windows.Forms.TextBox cemailBox;
        private System.Windows.Forms.TextBox cpasswordBox;
        private System.Windows.Forms.TextBox cphoneBox;
        private System.Windows.Forms.TextBox caddressBox;
        private System.Windows.Forms.Button csignupBtn;
        private System.Windows.Forms.Label resultLabel;
    }
}