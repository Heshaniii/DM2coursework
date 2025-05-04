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
            this.semailBox.Location = new System.Drawing.Point(133, 64);
            this.semailBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.semailBox.Name = "semailBox";
            this.semailBox.Size = new System.Drawing.Size(335, 20);
            this.semailBox.TabIndex = 0;
            // 
            // spasswordBox
            // 
            this.spasswordBox.Location = new System.Drawing.Point(133, 109);
            this.spasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spasswordBox.Name = "spasswordBox";
            this.spasswordBox.Size = new System.Drawing.Size(335, 20);
            this.spasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supplier Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier Password";
            // 
            // sloginButton
            // 
            this.sloginButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sloginButton.Location = new System.Drawing.Point(193, 200);
            this.sloginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sloginButton.Name = "sloginButton";
            this.sloginButton.Size = new System.Drawing.Size(133, 46);
            this.sloginButton.TabIndex = 4;
            this.sloginButton.Text = "Login";
            this.sloginButton.UseVisualStyleBackColor = false;
            this.sloginButton.Click += new System.EventHandler(this.sloginButton_Click);
            // 
            // sresultLabel
            // 
            this.sresultLabel.AutoSize = true;
            this.sresultLabel.Location = new System.Drawing.Point(131, 164);
            this.sresultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sresultLabel.Name = "sresultLabel";
            this.sresultLabel.Size = new System.Drawing.Size(35, 13);
            this.sresultLabel.TabIndex = 5;
            this.sresultLabel.Text = "empty";
            // 
            // SupplierLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.sresultLabel);
            this.Controls.Add(this.sloginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spasswordBox);
            this.Controls.Add(this.semailBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupplierLoginForm";
            this.Text = "SupplierLoginForm";
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