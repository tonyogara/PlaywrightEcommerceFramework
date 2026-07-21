using System.Reflection;
using System.Text.Json;
using System.Net;
using static System.Net.HttpStatusCode;
using NUnit.Framework;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.Core;
using PlaywrightEcommerceFramework.Workflows;
//20/07 

//Progress

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

    var cart = new PostNewCart(request,_shoppingTestContext);

    var response = await cart.CreatePostNewCartAsync();
   
    var responseBody = await response.TextAsync();

    var cartData = JsonSerializer.Deserialize<CartResponse>(responseBody, new JsonSerializerOptions 
    { 
        PropertyNameCaseInsensitive = true 
    });


if (cartData != null)
    {
        string cartId = cartData.Id;
        _shoppingTestContext.CartId = cartId;
    }

}    


}