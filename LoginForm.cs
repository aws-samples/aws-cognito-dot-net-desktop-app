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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CognitoHelper cognitoHelper = new CognitoHelper();
                string result = await cognitoHelper.ValidateUser(txtusername.Text, txtpassword.Text);
                Console.WriteLine(result);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                MessageBox.Show("Unable to validate the username and password");
            }
        }
    }
}
