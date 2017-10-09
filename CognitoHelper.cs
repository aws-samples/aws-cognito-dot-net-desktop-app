using System;
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
 
    public CognitoHelper()
    {

    }

    internal async Task<bool> SignUpUser(string username, string password, string email, string phonenumber)
    {
        AmazonCognitoIdentityProviderClient provider =
               new AmazonCognitoIdentityProviderClient(new Amazon.Runtime.AnonymousAWSCredentials());
       
        SignUpRequest signUpRequest = new SignUpRequest();

        signUpRequest.ClientId= CLIENTAPP_ID;
        signUpRequest.Username = username;
        signUpRequest.Password=password;
       

        AttributeType attributeType = new AttributeType();
        attributeType.Name= "phone_number";
        attributeType.Value= phonenumber;
        signUpRequest.UserAttributes.Add(attributeType);

        AttributeType attributeType1 = new AttributeType();
        attributeType1.Name = "email";
        attributeType1.Value= email;
        signUpRequest.UserAttributes.Add(attributeType1);

        
        try
        {

            SignUpResponse result =await provider.SignUpAsync(signUpRequest);
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
        return true;

    }
    internal async Task<bool> VerifyAccessCode(string username, string code)
    {
        AmazonCognitoIdentityProviderClient provider =
               new AmazonCognitoIdentityProviderClient(new Amazon.Runtime.AnonymousAWSCredentials());
        ConfirmSignUpRequest confirmSignUpRequest = new ConfirmSignUpRequest();
        confirmSignUpRequest.Username = username;
        confirmSignUpRequest.ConfirmationCode=code;
        confirmSignUpRequest.ClientId= CLIENTAPP_ID;
        try
        {
            ConfirmSignUpResponse confirmSignUpResult = provider.ConfirmSignUp(confirmSignUpRequest);
            Console.WriteLine(confirmSignUpResult.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return false;
        }

        return true;
       
    }
    internal async Task<string> ValidateUser(string username, string password) 
    {
        AmazonCognitoIdentityProviderClient provider =
                new AmazonCognitoIdentityProviderClient(new Amazon.Runtime.AnonymousAWSCredentials());
        CognitoUserPool userPool = new CognitoUserPool(this.POOL_ID, this.CLIENTAPP_ID, provider);
        
        CognitoUser user = new CognitoUser(username, this.CLIENTAPP_ID, userPool, provider);
        InitiateSrpAuthRequest authRequest = new InitiateSrpAuthRequest()
        {
            Password = password
        };

        AuthFlowResponse authResponse = await user.StartWithSrpAuthAsync(authRequest).ConfigureAwait(false);
        string accessToken = authResponse.AuthenticationResult.AccessToken;
        return accessToken;
    }


    internal async Task<CognitoAWSCredentials>  GetCredentials(string idprovider, string id)
    {
        var provider = new AmazonCognitoIdentityProviderClient(new AnonymousAWSCredentials());
        CognitoUserPool userPool = new CognitoUserPool(this.POOL_ID,this.CLIENTAPP_ID, provider);
        CognitoUser user = new CognitoUser(id, this.CLIENTAPP_ID, userPool, provider);

        string password = "userPassword";

        AuthFlowResponse context = await user.StartWithSrpAuthAsync(new InitiateSrpAuthRequest()
        {
            Password = password
        }).ConfigureAwait(false);

        CognitoAWSCredentials credentials =
            user.GetCognitoAWSCredentials("identityPoolID", new AppConfigAWSRegion().Region);

        return credentials;
    }
}
