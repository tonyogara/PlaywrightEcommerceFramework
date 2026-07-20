
using Microsoft.Playwright;
using PlaywrightEcommerceFramework.Models;


namespace PlaywrightEcommerceFramework.ApiClients;


public class PostNewCart
{
    //private readonly ShoppingTestContext _shoppingTestContext;
    private readonly IAPIRequestContext _request;
    private readonly ShoppingTestContext _shoppingTestContext;

    public PostNewCart(IAPIRequestContext request, ShoppingTestContext shoppingTestContext)
    {
        _request = request;
        _shoppingTestContext = shoppingTestContext;
    }



    //public async Task<IAPIResponse> CreatePostNewCartAsync(String cartIdStr)
    public async Task<IAPIResponse> CreatePostNewCartAsync()
    {
        return await _request.PostAsync("/carts");
        /*
        , 
        new APIRequestContextOptions
        {
            Data = cartIdStr
            
        });
*/
        
    }


}