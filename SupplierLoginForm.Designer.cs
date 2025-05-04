namespace DM2coursework
{
    partial class SupplierLoginForm
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
            this.semailBox = new System.Windows.Forms.TextBox();
            this.spasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sloginButton = new System.Windows.Forms.Button();
            this.sresultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // semailBox
            // 
            this.semailBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.semailBox.Location = new System.Drawing.Point(200, 98);
            this.semailBox.Name = "semailBox";
            this.semailBox.Size = new System.Drawing.Size(500, 26);
            this.semailBox.TabIndex = 0;
            // 
            // spasswordBox
            // 
            this.spasswordBox.Location = new System.Drawing.Point(200, 168);
            this.spasswordBox.Name = "spasswordBox";
            this.spasswordBox.Size = new System.Drawing.Size(500, 26);
            this.spasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Password";
            // 
            // sloginButton
            // 
            this.sloginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sloginButton.Location = new System.Drawing.Point(290, 308);
            this.sloginButton.Name = "sloginButton";
            this.sloginButton.Size = new System.Drawing.Size(200, 71);
            this.sloginButton.TabIndex = 4;
            this.sloginButton.Text = "Login";
            this.sloginButton.UseVisualStyleBackColor = false;
            this.sloginButton.Click += new System.EventHandler(this.sloginButton_Click);
            // 
            // sresultLabel
            // 
            this.sresultLabel.AutoSize = true;
            this.sresultLabel.Location = new System.Drawing.Point(196, 252);
            this.sresultLabel.Name = "sresultLabel";
            this.sresultLabel.Size = new System.Drawing.Size(0, 20);
            this.sresultLabel.TabIndex = 5;
            // 
            // SupplierLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 448);
            this.Controls.Add(this.sresultLabel);
            this.Controls.Add(this.sloginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spasswordBox);
            this.Controls.Add(this.semailBox);
            this.Name = "SupplierLoginForm";
            this.Text = "Supplier Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox semailBox;
        private System.Windows.Forms.TextBox spasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sloginButton;
        private System.Windows.Forms.Label sresultLabel;
    }
}