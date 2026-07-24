using Microsoft.Playwright;
using Microsoft.VisualBasic;

namespace PlaywrightEcommerceFramework.Pages;

public class Homepage
{

    private readonly IPage _page

    public Homepage(IPage page)
    {
        _page = page;
    }


    public async Task OpenAccess()
    {
        await _page.GotoAsync("https://practiceofsoftwaretesting.com");

    }

    public async Task selectCategory(string category)
    {
        await _page.GetByRole(AriaRole.Link,
            new() { Name = "Categories" }).ClickAsync();

        await _page.GetByRole(AriaRole.Link,
            new() { Name = category }).ClickAsync();

    }

}