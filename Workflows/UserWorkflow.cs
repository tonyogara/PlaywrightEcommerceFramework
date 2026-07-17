
using Microsoft.Playwright;
using NUnit.Framework.Constraints;
using PlaywrightEcommerceFramework.Models;
using PlaywrightEcommerceFramework.ApiClients;
using PlaywrightEcommerceFramework.ApiResponses;
using System.Text.Json;

//using PlaywrightApiDemo.Models;

namespace PlaywrightEcommerceFramework.Workflows;
public class UserWorkflow 

{ 

    private readonly IAPIRequestContext _request; 

    private readonly ShoppingTestContext _context; 

  

    public UserWorkflow( IAPIRequestContext request, ShoppingTestContext context) 
    { 
        _request = request; 
        _context = context; 
    } 

  

    public async Task CreateAndLogin() 
    { 
        var createUser = 
            new PostNewUser(_request, _context); 

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

  

        await createUser.CreatePostUserLoginAsync(user); 

        var login = new PostUserLogin(_request);
         var response = await login.CreatePostUserLoginAsync(new ExistingUser { email = user.Email, password = user.Password });
        Console.WriteLine($"Status: {response.Status}");
        var responseBody = await response.TextAsync();
       
       var loginResponse=JsonSerializer.Deserialize<LoginResponse>(responseBody);
       var tokenIs = loginResponse?.Token;
       Console.WriteLine($"Token issss :{tokenIs}");

       
       
       
        Console.WriteLine($"Response: {responseBody}");
        var responseJson = await response.JsonAsync();
       



         Console.WriteLine(_context.CartId);
         //Console.WriteLine($"Token is: {_context.Token}");
         
         //Console.WriteLine($"Token is: {responseJson.}");
         Console.WriteLine(_context.User.FirstName);
         Console.WriteLine(_context.User.Address.City);

        //var token = responseJson.GetProperty("token").GetString();
        //_context.Token = token; 

  
/*
        var login = 

            new LoginApi(_request, _context); 

  

        await login.Login(); 
*/

    } 

} 