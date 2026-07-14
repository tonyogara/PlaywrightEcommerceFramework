using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;


namespace PlaywrightEcommerceFramework.Tests;

 [TestFixture]
public class UserLogin : ApiTestBase
{ 
    [Test]
public async Task User_Login_Should_Be_Successful()
{
    //var usersClient = new UsersClient(request);
    var postUserLogin = new PostUserLogin(request);

    var existingUser = new ExistingUser
    {
        email = "tony29970a2a-5105-4999-aad3-a52a2732ce04@gmail.com",
        password = "P@55word1111111"
    };    

    var response = await postUserLogin.CreatePostUserLoginAsync(existingUser);

var responseBody = await response.TextAsync();

Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

Assert.That(response.Status, Is.EqualTo(200), "Expected status code 200 for successful login.");
}    

}