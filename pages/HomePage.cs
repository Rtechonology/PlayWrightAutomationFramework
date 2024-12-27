using Microsoft.Playwright;
using System.Threading.Tasks;

public class HomePage
{
    private readonly IPage _page;

    public HomePage(IPage page)
    {
        _page = page;
    }

    // Method to get the title of the page
    public async Task<string> GetTitle()
    {
        return await _page.TitleAsync();
    }

    // Method to check if a specific element is present
    public async Task<bool> IsElementPresent(string selector)
    {
        var element = await _page.QuerySelectorAsync(selector);
        return element != null;
    }

    // Method to get the text content of a specific element
    public async Task<string> GetElementText(string selector)
    {
        var element = await _page.QuerySelectorAsync(selector);
        return await element.InnerTextAsync();
    }
}
