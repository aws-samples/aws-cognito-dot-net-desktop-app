namespace CognitoNetSample
{
    partial class ForgotPassword
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
            this.lblusername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(144, 57);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(35, 13);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(147, 98);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '*';
            this.txtnewpassword.Size = new System.Drawing.Size(100, 20);
            this.txtnewpassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code";
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(147, 147);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.Size = new System.Drawing.Size(100, 20);
            this.txtcode.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button button1;
    }
}