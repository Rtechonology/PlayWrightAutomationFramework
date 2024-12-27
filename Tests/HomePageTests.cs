using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Threading.Tasks;

[TestFixture]
public class HomePageTests
{
    private PlaywrightDriver _driver;
    private HomePage _homePage;

    [SetUp]
    public async Task SetUp()
    {
        _driver = new PlaywrightDriver();
        await _driver.Setup();
        _homePage = new HomePage(_driver.Page);

        // Navigate to the website's homepage
        await _driver.Page.GotoAsync("https://example.com");  // Replace with the desired URL
    }

    [Test]
    public async Task ValidateHomePageTitle()
    {
        // Assert that the title is as expected
        var title = await _homePage.GetTitle();
        ClassicAssert.AreEqual("Example Domain", title);  // Replace with expected title
    }

    [Test]
    public async Task ValidateHomePageElementPresence()
    {
        // Assert that a specific element is present
        var isElementPresent = await _homePage.IsElementPresent("h1");  // Replace with the selector for the element you want to check
        ClassicAssert.IsTrue(isElementPresent, "The expected element is not present on the homepage.");
    }

    [Test]
    public async Task ValidateHomePageElementText()
    {
        // Assert that the element text is correct
        var elementText = await _homePage.GetElementText("h1");  // Replace with the selector for the element you want to check
        ClassicAssert.AreEqual("Example Domain", elementText);  // Replace with the expected text
    }

    [TearDown]
    public async Task TearDown()
    {
        await _driver.Teardown();
    }
}
