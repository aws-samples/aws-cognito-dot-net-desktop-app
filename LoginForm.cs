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
        Amazon.Extensions.CognitoAuthentication.CognitoUser cognitoUser = null;
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
                cognitoUser = await cognitoHelper.ValidateUser(txtusername.Text, txtpassword.Text);
                Console.WriteLine(cognitoUser.Username);
                string bucketsforuser = await cognitoHelper.GetS3BucketsAsync(cognitoUser);
                MessageBox.Show(bucketsforuser,"Buckets for the users");
                
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                MessageBox.Show("Unable to validate the username and password");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
        

             ForgotPassword forgotui = new ForgotPassword();
             forgotui.ShowDialog();

          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CognitoHelper cognitoHelper = new CognitoHelper();

            System.Diagnostics.Process.Start(cognitoHelper.GetCustomHostedURL());
        }
    }
}
