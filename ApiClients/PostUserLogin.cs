
using Microsoft.Playwright;
using PlaywrightEcommerceFramework.Models;


namespace PlaywrightEcommerceFramework.ApiClients;


public class PostUserLogin
{
    private readonly IAPIRequestContext _request;

    public PostUserLogin(IAPIRequestContext request)
    {
        _request = request;
    }



    public async Task<IAPIResponse> CreatePostUserLoginAsync(ExistingUser existingUser)
    {
        var postData = new

        {
        email = existingUser.email,
        password = existingUser.password


    };

 
        return await _request.PostAsync("/users/login", 
        new APIRequestContextOptions
        {
            DataObject = postData
        });
    }   

}