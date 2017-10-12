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
       
        public ForgotPassword()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CognitoHelper helper = new CognitoHelper();
                await helper.ResetPassword(txtusername.Text);
                MessageBox.Show("Password reset request submitted. Please check the code on phone");
                lblcode.Enabled = true;
                txtcode.Enabled = true;
                lblnewpassword.Enabled = true;
                txtnewpassword.Enabled = true;
                btnupdatepass.Enabled = true;
               
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);

            }
            
        }

        private async void btnupdatepass_Click(object sender, EventArgs e)
        {
            try
            {
                CognitoHelper helper = new CognitoHelper();
                await helper.UpdatePassword(txtusername.Text,txtcode.Text,txtnewpassword.Text);
                MessageBox.Show("Password updated.");
            }
            catch (Exception exp)
            {

                MessageBox.Show("Unable to update the password"+ exp.Message);
            }
        }
    }
}
