using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;
using NUnit.Framework.Constraints;
using Microsoft.Playwright;

namespace PlaywrightEcommerceFramework.Helpers;


public class CreateNewUser : ApiTestBase
{

  private readonly IAPIRequestContext _request;
  private readonly ShoppingTestContext _shoppingTestContext;


public CreateNewUser(IAPIRequestContext request, ShoppingTestContext shoppingTestContext)
{
    _request = request;
    _shoppingTestContext = shoppingTestContext; 
} 
  

public async Task CreateUser()
{
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
}

















