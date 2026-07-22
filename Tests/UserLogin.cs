using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;
//using PlaywrightEcommerceFramework.ApiResponses;




namespace PlaywrightEcommerceFramework.Tests;

 //[TestFixture]
public class UserLogin : ApiTestBase
{ 
   // [Test]
public async Task User_Login_Should_Be_Successful()
{
    //var usersClient = new UsersClient(request);
    var postUserLogin = new PostUserLogin(request);

    var existingUser = new ExistingUser
    {
        email = "tonyad8fea87-a600-41e9-9b86-ff3cf160d058@gmail.com",
        //email = _shoppingTestContext.Emaill,
        password = "P@55word1111111"
    };    

    var response = await postUserLogin.CreatePostUserLoginAsync(existingUser);

var responseBody = await response.TextAsync();

Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

var loginResponse = JsonSerializer.Deserialize<LoginResponse>(responseBody);
//Console.WriteLine(loginResponse?.Token);
Console.WriteLine($"Token isssss: {loginResponse?.Token}");

_shoppingTestContext.Token = loginResponse?.Token ?? "";
Console.WriteLine($"Token in shoppingTestContext: {_shoppingTestContext.Token}");
//Console.WriteLine($"Email in shoppingTestContext: {_shoppingTestContext.Emaill}");


Assert.That(response.Status, Is.EqualTo(200), "Expected status code 200 for successful login.");
}    

}