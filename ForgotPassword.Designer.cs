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
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.btnforgotpass = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnupdatepass = new System.Windows.Forms.Button();
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
            this.lblusername.Location = new System.Drawing.Point(200, 57);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 13);
            this.lblusername.TabIndex = 1;
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Enabled = false;
            this.lblnewpassword.Location = new System.Drawing.Point(38, 153);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(78, 13);
            this.lblnewpassword.TabIndex = 2;
            this.lblnewpassword.Text = "New Password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Enabled = false;
            this.txtnewpassword.Location = new System.Drawing.Point(203, 153);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '*';
            this.txtnewpassword.Size = new System.Drawing.Size(100, 20);
            this.txtnewpassword.TabIndex = 3;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Enabled = false;
            this.lblcode.Location = new System.Drawing.Point(38, 104);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(32, 13);
            this.lblcode.TabIndex = 4;
            this.lblcode.Text = "Code";
            // 
            // txtcode
            // 
            this.txtcode.Enabled = false;
            this.txtcode.Location = new System.Drawing.Point(203, 104);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '*';
            this.txtcode.Size = new System.Drawing.Size(100, 20);
            this.txtcode.TabIndex = 5;
            // 
            // btnforgotpass
            // 
            this.btnforgotpass.Location = new System.Drawing.Point(32, 209);
            this.btnforgotpass.Name = "btnforgotpass";
            this.btnforgotpass.Size = new System.Drawing.Size(110, 23);
            this.btnforgotpass.TabIndex = 6;
            this.btnforgotpass.Text = "Forgot Password";
            this.btnforgotpass.UseVisualStyleBackColor = true;
            this.btnforgotpass.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(203, 57);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 20);
            this.txtusername.TabIndex = 7;
            // 
            // btnupdatepass
            // 
            this.btnupdatepass.Enabled = false;
            this.btnupdatepass.Location = new System.Drawing.Point(203, 209);
            this.btnupdatepass.Name = "btnupdatepass";
            this.btnupdatepass.Size = new System.Drawing.Size(100, 23);
            this.btnupdatepass.TabIndex = 8;
            this.btnupdatepass.Text = "Update Password";
            this.btnupdatepass.UseVisualStyleBackColor = true;
            this.btnupdatepass.Click += new System.EventHandler(this.btnupdatepass_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 260);
            this.Controls.Add(this.btnupdatepass);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnforgotpass);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.lblcode);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.lblnewpassword);
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
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnforgotpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnupdatepass;
    }
}