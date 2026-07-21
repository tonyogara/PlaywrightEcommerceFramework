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



 //[TestFixture]
public class NewCartProducts : ApiTestBase
{ 
[Test]
public async Task New_Cart_Should_Be_Created_Successfully()
{  
    var shoppingWorkflow = new ShoppingWorkflow(request, _shoppingTestContext);
   
    await shoppingWorkflow.CreateAndLoginAndNewCart();

    


}
   /* 21/07 - Original code for this class
   // [Test]
public async Task Add_Products_To_Cart_Should_Be_Successful()
{
    //var usersClient = new UsersClient(request);
    var postNewProductsToCart= new PostNewCartProductIds(request);

    var newCartProductsModel = new NewCartProductsModel
    {
        ProductId = "01KXG13ZVC5CDYERS17QWAQE35",
        Quantity = "2"
    };

    var response = await postNewProductsToCart.CreatePostNewCartProductsAsync(newCartProductsModel);

var responseBody = await response.TextAsync();

Console.WriteLine($"Status: {response.Status}");
Console.WriteLine($"Response: {responseBody}");

//Assert.That(response.Status, Is.EqualTo(201));
}    
*/


}