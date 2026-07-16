
using Microsoft.Playwright;
using NUnit.Framework.Constraints;
using PlaywrightEcommerceFramework.Models;
//using PlaywrightApiDemo.Models;

namespace PlaywrightEcommerceFramework.ApiClients;
public class PostNewUser
{
    private readonly IAPIRequestContext _request;
    private readonly ShoppingTestContext _shoppingTestContext;

    public PostNewUser(IAPIRequestContext request, ShoppingTestContext shoppingTestContext)
    {
        _request = request;
        _shoppingTestContext = shoppingTestContext;
    }



    public async Task<IAPIResponse> CreatePostUserLoginAsync(NewUser nu)
    {
            
    var postData = new
    {
        first_name = nu.FirstName,
        last_name = nu.LastName,
        address = new
        {
            street = nu.Address.Street,
            house_number = nu.Address.HouseNumber,
            city = nu.Address.City,
            state = nu.Address.State,
            country = nu.Address.Country,
            postal_code = nu.Address.PostalCode
        },
        phone = nu.Phone,
        dob = nu.Dob,
        password = nu.Password,
        email = nu.Email
    };

        return await _request.PostAsync("/users/register", 
        new APIRequestContextOptions
        {
            DataObject = postData
        });
    }   


}