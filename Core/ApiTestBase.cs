using Microsoft.Playwright;
using NUnit.Framework;

namespace PlaywrightEcommerceFramework.Core;

public class ApiTestBase
{
    protected IPlaywright _playwright;
    protected IAPIRequestContext request;

    protected ApiFactory _apiFactory;

    protected ShoppingTestContext _shoppingTestContext = new ShoppingTestContext();


    [SetUp]
    public async Task Setup()
    {
        _playwright = await Playwright.CreateAsync();
        
        _apiFactory = new ApiFactory(_playwright);

        request = await _apiFactory.CreateClient("https://api.practicesoftwaretesting.com/");

        _shoppingTestContext = new ShoppingTestContext();

    }


    [TearDown]
    public async Task TearDown()
    {
        await request.DisposeAsync();
        _playwright.Dispose();
    }
}