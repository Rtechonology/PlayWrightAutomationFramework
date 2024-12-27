using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;

[TestFixture]
public class ApiTests
{
    private ApiClient _apiClient;

    [SetUp]
    public void Setup()
    {
        _apiClient = new ApiClient();
    }

    [Test]
    public async Task GetUserDetails_ShouldReturnSuccess()
    {
        // Arrange
        var url = "https://jsonplaceholder.typicode.com/users/1";

        // Act
        var response = await _apiClient.GetAsync(url);

        // Assert
        ClassicAssert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);
    }

    [Test]
    public async Task CreateUser_ShouldReturnCreated()
    {
        // Arrange
        var url = "https://jsonplaceholder.typicode.com/users";
        var content = new StringContent("{\"name\":\"John\", \"email\":\"john@example.com\"}", System.Text.Encoding.UTF8, "application/json");

        // Act
        var response = await _apiClient.PostAsync(url, content);

        // Assert
        ClassicAssert.AreEqual(System.Net.HttpStatusCode.Created, response.StatusCode);
    }

    [TearDown]
    public void TearDown()
    {
        // Clean up after tests if necessary
    }
}
