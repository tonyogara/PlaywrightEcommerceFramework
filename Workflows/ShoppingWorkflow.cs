
using Microsoft.Playwright;
using NUnit.Framework.Constraints;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.ApiResponses;
using System.Text.Json;
using NUnit.Framework;

//using PlaywrightApiDemo.Models;

namespace PlaywrightEcommerceFramework.Workflows;
public class ShoppingWorkflow 
{ 

    private readonly IAPIRequestContext _request; 
    private readonly ShoppingTestContext _context; 

    public ShoppingWorkflow(IAPIRequestContext request, ShoppingTestContext context) 
    { 
        _request = request; 
        _context = context; 
    } 

  

public async Task CreateAndLoginAndNewCart() 
    { 
        
        //Create user
        var createUser = new PostNewUser(_request, _context); 

        var user = new Models.NewUser 
        { 
            FirstName = "Tony", 
            LastName = "OGara", 

            Address = new Address 
            { 
                Street = "High Street", 
                HouseNumber = "25", 
                City = "Edinburgh", 
                State = "Scotland", 
                Country = "United Kingdom", 
                PostalCode = "EH1 1AA" 
            }, 
  
            Phone = "07123456789", 
            Dob = "1973-01-01", 
            Password = "P@55word1111111", 
            Email = $"tony{Guid.NewGuid()}@gmail.com" 
        }; 

        var response = await createUser.CreatePostUserLoginAsync(user);
      //  Console.WriteLine($"Status for login: {response.Status}");


        //User login
        var login = new PostUserLogin(_request);
        var responseLogin = await login.CreatePostUserLoginAsync(new ExistingUser { email = user.Email, password = user.Password });
       
        Console.WriteLine($"Status for login: {responseLogin.Status}");
        
        var responseBody = await responseLogin.TextAsync();
        var loginResponse=JsonSerializer.Deserialize<LoginResponse>(responseBody);
       
        var tokenIs = loginResponse?.Token;
        //var responseJson = await response.JsonAsync();
        

        //Create a new cart
        var postNewCart = new PostNewCart(_request, _context);

        var responseNewCart = await postNewCart.CreatePostNewCartAsync();
        Console.WriteLine("Response New Cart" + responseNewCart.ToString);





    } 

} 
