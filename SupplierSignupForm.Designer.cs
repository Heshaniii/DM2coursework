namespace DM2coursework
{
    partial class SupplierSignupForm
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.ssignupBtn = new System.Windows.Forms.Button();
            this.saddressBox = new System.Windows.Forms.TextBox();
            this.sphoneBox = new System.Windows.Forms.TextBox();
            this.spasswordBox = new System.Windows.Forms.TextBox();
            this.semailBox = new System.Windows.Forms.TextBox();
            this.snameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(218, 312);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 23;
            // 
            // ssignupBtn
            // 
            this.ssignupBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ssignupBtn.Location = new System.Drawing.Point(290, 357);
            this.ssignupBtn.Name = "ssignupBtn";
            this.ssignupBtn.Size = new System.Drawing.Size(200, 71);
            this.ssignupBtn.TabIndex = 22;
            this.ssignupBtn.Text = "Sign up";
            this.ssignupBtn.UseVisualStyleBackColor = false;
            this.ssignupBtn.Click += new System.EventHandler(this.ssignupBtn_Click);
            // 
            // saddressBox
            // 
            this.saddressBox.Location = new System.Drawing.Point(213, 263);
            this.saddressBox.Name = "saddressBox";
            this.saddressBox.Size = new System.Drawing.Size(500, 26);
            this.saddressBox.TabIndex = 21;
            // 
            // sphoneBox
            // 
            this.sphoneBox.Location = new System.Drawing.Point(211, 204);
            this.sphoneBox.Name = "sphoneBox";
            this.sphoneBox.Size = new System.Drawing.Size(500, 26);
            this.sphoneBox.TabIndex = 20;
            // 
            // spasswordBox
            // 
            this.spasswordBox.Location = new System.Drawing.Point(212, 147);
            this.spasswordBox.Name = "spasswordBox";
            this.spasswordBox.Size = new System.Drawing.Size(500, 26);
            this.spasswordBox.TabIndex = 19;
            // 
            // semailBox
            // 
            this.semailBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.semailBox.Location = new System.Drawing.Point(212, 90);
            this.semailBox.Name = "semailBox";
            this.semailBox.Size = new System.Drawing.Size(500, 26);
            this.semailBox.TabIndex = 18;
            // 
            // snameBox
            // 
            this.snameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.snameBox.Location = new System.Drawing.Point(211, 41);
            this.snameBox.Name = "snameBox";
            this.snameBox.Size = new System.Drawing.Size(500, 26);
            this.snameBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Supplier Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Supplier Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Supplier Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Supplier Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supplier Name:";
            // 
            // SupplierSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.ssignupBtn);
            this.Controls.Add(this.saddressBox);
            this.Controls.Add(this.sphoneBox);
            this.Controls.Add(this.spasswordBox);
            this.Controls.Add(this.semailBox);
            this.Controls.Add(this.snameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplierSignupForm";
            this.Text = "SupplierSignupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button ssignupBtn;
        private System.Windows.Forms.TextBox saddressBox;
        private System.Windows.Forms.TextBox sphoneBox;
        private System.Windows.Forms.TextBox spasswordBox;
        private System.Windows.Forms.TextBox semailBox;
        private System.Windows.Forms.TextBox snameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}