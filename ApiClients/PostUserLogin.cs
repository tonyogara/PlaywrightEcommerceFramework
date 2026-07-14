
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


        //email = "tony19f82f37-b0d5-48e0-ae14-cbf940c84cd2@gmail.com",
        //password = "P@55word1111111"
    };

 
        return await _request.PostAsync("/users/login", 
        new APIRequestContextOptions
        {
            DataObject = postData
        });
    }   

}