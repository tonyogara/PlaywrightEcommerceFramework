
using Microsoft.Playwright;
using PlaywrightEcommerceFramework.Models;


namespace PlaywrightEcommerceFramework.ApiClients;


public class PostNewCart
{
    private readonly IAPIRequestContext _request;

    public PostNewCart(IAPIRequestContext request)
    {
        _request = request;
    }



    public async Task<IAPIResponse> CreatePostNewCartAsync(String cartIdStr)
    {
        

 
        return await _request.PostAsync("/carts", 
        new APIRequestContextOptions
        {
            Data = cartIdStr
        });
    }   

}