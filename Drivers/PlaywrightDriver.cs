using Microsoft.Playwright;
using System.Threading.Tasks;

public class PlaywrightDriver
{
    private IBrowser _browser;
    private IPage _page;

    public IPage Page => _page;

    public async Task Setup()
    {
        var playwright = await Playwright.CreateAsync();
        _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        _page = await _browser.NewPageAsync();
    }

    public async Task Teardown()
    {
        await _browser.CloseAsync();
    }
}
