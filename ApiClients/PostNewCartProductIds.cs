
using Microsoft.Playwright;
using PlaywrightEcommerceFramework.Models;


namespace PlaywrightEcommerceFramework.ApiClients;


public class PostNewCartProductIds
{
    private readonly IAPIRequestContext _request;

    public PostNewCartProductIds(IAPIRequestContext request)
    {
        _request = request;
    }



    public async Task<IAPIResponse> CreatePostNewCartProductsAsync(NewCartProductsModel ncpm, String cart_ID)
    {
        //return await _request.PostAsync("/carts/{id}", 
        
        return await _request.PostAsync($"/carts/{cart_ID}", 
        new APIRequestContextOptions
        {       
            DataObject = ncpm
        });
    }  

}