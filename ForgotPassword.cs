using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Amazon.Extensions.CognitoAuthentication;
namespace CognitoNetSample
{
    public partial class ForgotPassword : Form
    {
        CognitoUser user;
        public ForgotPassword(CognitoUser cognitoUser)
        {
            InitializeComponent();
            this.user = cognitoUser;
            this.lblusername.Text = cognitoUser.Username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await user.ConfirmForgotPasswordAsync(txtcode.Text, txtnewpassword.Text);
                MessageBox.Show("Successfully changed the password");
                this.Hide();
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);

            }
            
        }
    }
}
