namespace DM2coursework
{
    partial class CustomerLoginForm
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
            this.cemailBox = new System.Windows.Forms.TextBox();
            this.cpasswordBox = new System.Windows.Forms.TextBox();
            this.cloginButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cemailBox
            // 
            this.cemailBox.Location = new System.Drawing.Point(268, 122);
            this.cemailBox.Name = "cemailBox";
            this.cemailBox.Size = new System.Drawing.Size(400, 26);
            this.cemailBox.TabIndex = 0;
            // 
            // cpasswordBox
            // 
            this.cpasswordBox.Location = new System.Drawing.Point(268, 189);
            this.cpasswordBox.Name = "cpasswordBox";
            this.cpasswordBox.Size = new System.Drawing.Size(400, 26);
            this.cpasswordBox.TabIndex = 1;
            // 
            // cloginButton
            // 
            this.cloginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cloginButton.Location = new System.Drawing.Point(292, 312);
            this.cloginButton.Name = "cloginButton";
            this.cloginButton.Size = new System.Drawing.Size(200, 71);
            this.cloginButton.TabIndex = 2;
            this.cloginButton.Text = "Login";
            this.cloginButton.UseVisualStyleBackColor = false;
            this.cloginButton.Click += new System.EventHandler(this.cloginButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(201, 269);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(52, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "empty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Password";
            // 
            // CustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.cloginButton);
            this.Controls.Add(this.cpasswordBox);
            this.Controls.Add(this.cemailBox);
            this.Name = "CustomerLoginForm";
            this.Text = "Customer Login Form";
            this.Load += new System.EventHandler(this.CustomerLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cemailBox;
        private System.Windows.Forms.TextBox cpasswordBox;
        private System.Windows.Forms.Button cloginButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}