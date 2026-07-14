using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;


namespace PlaywrightEcommerceFramework.Tests;

 //[TestFixture]
public class PostTests : ApiTestBase
{ 
   // [Test]
public async Task Create_New_User_Should_Be_Successful()
{
    //var usersClient = new UsersClient(request);
    var postNewUser = new PostNewUser(request);

    var newUser = new NewUser
    {
        FirstName = "Tony",
        LastName = "OGara",
        Address = new Address
        {   
            Street = "High Street",
            HouseNumber = "25",
            City = "Edinburgh",
            State = "Scotland",
            Country = "United Kingdom",
            PostalCode = "EH1 1AA"
        },
        Phone = "07123456789",
        Dob = "1973-01-01",
        Password = "P@55word1111111",
        Email = $"tony{Guid.NewGuid()}@gmail.com"
    };

    var response = await postNewUser.CreatePostUserLoginAsync(newUser);

var responseBody = await response.TextAsync();

Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

Assert.That(response.Status, Is.EqualTo(201));
}    

}