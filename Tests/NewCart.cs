using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;
using PlaywrightEcommerceFramework.Workflows;


namespace PlaywrightEcommerceFramework.Tests;

 [TestFixture]
public class NewCart : ApiTestBase
{
    [Test]
    [CancelAfter(5000)]
    public async Task New_Cart_Should_Be_Created_Successfully()
{

    var userWorkFlow = new UserWorkflow(request, _shoppingTestContext);

    await userWorkFlow.CreateAndLogin();

    Console.WriteLine(_shoppingTestContext.Token);


    var cart = new PostNewCart(request,_shoppingTestContext);

    var response = await cart.CreatePostNewCartAsync();
   
    var responseBody = await response.TextAsync();

/*
    var cartData = JsonSerializer.Deserialize<NewCart>(responseBody, new JsonSerializerOptions 
{ 
    PropertyNameCaseInsensitive = true 
});

int cartId = cartData.Id;
*/


    //Console.WriteLine("Response id isssss: "+responseBody.);
    
     Console.WriteLine("------------");
    //Console.WriteLine("Response id isssss: "+responseBody.);


    /* Commented HJuly 20th

    var response = await postNewCart.CreatePostNewCartAsync();

var responseBody = await response.TextAsync();

Console.WriteLine($"Cart ID: {cartId}");
Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

Assert.That(response.Status, Is.EqualTo(201), "Expected status code 201 for successful cart creation.");

*/

}    


}