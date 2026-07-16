
using Microsoft.Playwright;
using NUnit.Framework.Constraints;
using PlaywrightEcommerceFramework.Models;
//using PlaywrightApiDemo.Models;

namespace PlaywrightEcommerceFramework.Workflows;
public class UserWorkflow 

{ 

    private readonly IAPIRequestContext _request; 

    private readonly ShoppingTestContext _context; 

  

    public UserWorkflow( 

        IAPIRequestContext request, 

        ShoppingTestContext context) 

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

  
/*
        var login = 

            new LoginApi(_request, _context); 

  

        await login.Login(); 
*/

    } 

} 