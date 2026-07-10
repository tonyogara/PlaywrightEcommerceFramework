
using Microsoft.Playwright;
using PlaywrightEcommerceFramework.Models;
//using PlaywrightApiDemo.Models;


namespace PlaywrightEcommerceFramework.ApiClients;


public class PostNewUser
{
    private readonly IAPIRequestContext _request;

    public PostNewUser(IAPIRequestContext request)
    {
        _request = request;
    }



    public async Task<IAPIResponse> CreatePostNewUserAsync(NewUser nu)
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

    
        /*
        {
            userFirstName = nu.FirstName,
            userLastName = nu.LastName,
            userStreet = nu.Address.Street,
            userHouse_number = nu.Address.HouseNumber,
            userCity = nu.Address.City,
            userState = nu.Address.State,
            userCountry = nu.Address.Country,
            userPostal_code = nu.Address.PostalCode,
            userPhone = nu.Phone,
            userDob = nu.Dob,
            userPassword = nu.Password,
            userEmail = nu.Email,      
        };*/

        //Console.WriteLine(JsonSerializer.Serialize(postData));

        return await _request.PostAsync("/users/register", 
        new APIRequestContextOptions
        {
            DataObject = postData
        });
    }   

}