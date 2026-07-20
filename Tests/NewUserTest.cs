using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;
using PlaywrightEcommerceFramework.Workflows;
using NUnit.Framework.Constraints;
using Microsoft.Playwright.Core;


namespace PlaywrightEcommerceFramework.Tests;

 //[TestFixture]

public class NewUserTest : ApiTestBase
{ 

public UserWorkflow _userWorkflow;

//[Test]
public async Task Create_New_User_Should_Be_Successfully()
{
    _userWorkflow = new UserWorkflow(request, _shoppingTestContext);
    await _userWorkflow.CreateAndLogin();

    Console.WriteLine("User name: " + _shoppingTestContext.User.FirstName + " " + _shoppingTestContext.User.LastName);
    Console.WriteLine("User email: " + _shoppingTestContext.User.Email);
    Console.WriteLine("User password: " + _shoppingTestContext.User.Password);
    Console.WriteLine("User address: " + _shoppingTestContext.User.Address.Street + " " + _shoppingTestContext.User.Address.HouseNumber + ", " +
                      _shoppingTestContext.User.Address.City + ", " + _shoppingTestContext.User.Address.State + ", " +
                      _shoppingTestContext.User.Address.Country + ", " + _shoppingTestContext.User.Address.PostalCode);
    Console.WriteLine("User phone: " + _shoppingTestContext.User.Phone);
    Console.WriteLine("User date of birth: " + _shoppingTestContext.User.Dob);
    Console.WriteLine("User password: " + _shoppingTestContext.User.Password);
    Console.WriteLine("User email: " + _shoppingTestContext.User.Email);    
    Console.WriteLine("User token: " + _shoppingTestContext.Token);

}



    






    /*
    [Test]
public async Task Create_New_User_Should_Be_Successful()
{
    //var usersClient = new UsersClient(request);
    //the parameter shoppingTestContext is passed to the PostNewUser constructor from ApiTestBase
    // to allow the test to access and modify the shared context for the shopping test.
    var postNewUser = new PostNewUser(request, _shoppingTestContext);

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
        Email = $"tony{Guid.NewGuid()}@gmail.com",

        
    };

_shoppingTestContext.Emaill = newUser.Email;
var response = await postNewUser.CreatePostUserLoginAsync(newUser);

var responseBody = await response.TextAsync();



Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");


//_shoppingTestContext.User =  responseBody; 
//_shoppingTestContext.Emaill = 

Console.WriteLine($"Email is: {_shoppingTestContext.Emaill}");

Assert.That(response.Status, Is.EqualTo(201));
}    
*/

}