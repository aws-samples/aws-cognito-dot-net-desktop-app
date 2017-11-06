using System;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon;

using Amazon.CognitoIdentity;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.Runtime;
// Required for the GetS3BucketsAsync example
using Amazon.S3;
using Amazon.S3.Model;
public class CognitoHelper
{
    private string POOL_ID = ConfigurationManager.AppSettings["POOL_id"];
    private string CLIENTAPP_ID = ConfigurationManager.AppSettings["CLIENT_id"];
    private string FED_POOL_ID = ConfigurationManager.AppSettings["FED_POOL_id"];

    private string CUSTOM_DOMAIN = ConfigurationManager.AppSettings["CUSTOMDOMAIN"];

    private string REGION = ConfigurationManager.AppSettings["AWSREGION"];

    public CognitoHelper()
    {

    }

    internal string GetCustomHostedURL()
    {
        return string.Format("https://{0}.auth.{1}.amazoncognito.com/login?response_type=code&client_id={2}&redirect_uri=https://sid343.reinvent-workshop.com/", CUSTOM_DOMAIN, REGION, CLIENTAPP_ID);
    }

    internal async Task<bool> SignUpUser(string username, string password, string email, string phonenumber)
    {
        
        return true;

    }
    internal async Task<bool> VerifyAccessCode(string username, string code)
    {
        return true;
       
    }
    internal async Task<CognitoUser> ResetPassword(string username)
    {
        return null;
       
    }

    internal async Task<CognitoUser> UpdatePassword(string username, string code, string newpassword)
    {
        return null;
    }

    internal async Task<CognitoUser> ValidateUser(string username, string password) 
    {
        return null;
    }


   

    public async Task<string> GetS3BucketsAsync(CognitoUser user)
    {
        CognitoAWSCredentials credentials =
           user.GetCognitoAWSCredentials(FED_POOL_ID, new AppConfigAWSRegion().Region);
        StringBuilder bucketlist = new StringBuilder();

        bucketlist.Append("================Cognito Credentails==================\n");
        bucketlist.Append("Access Key - " + credentials.GetCredentials().AccessKey);
        bucketlist.Append("\nSecret - " + credentials.GetCredentials().SecretKey);
        bucketlist.Append("\nSession Token - " + credentials.GetCredentials().Token);

        bucketlist.Append("\n================User Buckets==================\n");

        using (var client = new AmazonS3Client(credentials))
        {
            ListBucketsResponse response =
                await client.ListBucketsAsync(new ListBucketsRequest()).ConfigureAwait(false);

            foreach (S3Bucket bucket in response.Buckets)
            {
                bucketlist.Append(bucket.BucketName);

                bucketlist.Append("\n");
            }
        }
        Console.WriteLine(bucketlist.ToString());
        return bucketlist.ToString();
    }

}
