using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CognitoNetSample
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CognitoHelper helper = new CognitoHelper();
            bool success = await helper.SignUpUser(txtUsername.Text, txtPassword.Text, txtEmail.Text, txtPhone.Text);
            if (success)
            {
                MessageBox.Show("User Added Successfully! Please validate the phone number.");
                CodeEntry codeEntry = new CodeEntry(txtUsername.Text, txtPhone.Text);
                codeEntry.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Unable to add the user");
            }

        }
    }
}
