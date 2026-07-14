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
public class NewCart : ApiTestBase
{ 
    [Test]
public async Task New_Cart_Should_Be_Created_Successfully()
{
    //var usersClient = new UsersClient(request);
    var postNewCart = new PostNewCart(request);

    //var cartId = "123";
    // Generates a 5-digit random number string
    var cartId = Random.Shared.Next(10000, 100000).ToString();


    var response = await postNewCart.CreatePostNewCartAsync(cartId);

var responseBody = await response.TextAsync();

Console.WriteLine($"Cart ID: {cartId}");
Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

Assert.That(response.Status, Is.EqualTo(201), "Expected status code 201 for successful cart creation.");
}    


}