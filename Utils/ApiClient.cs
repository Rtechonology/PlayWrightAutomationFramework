using System.Net.Http;
using System.Threading.Tasks;

public class ApiClient
{
    private readonly HttpClient _client;

    public ApiClient()
    {
        _client = new HttpClient();
    }

    // GET request
    public async Task<HttpResponseMessage> GetAsync(string url)
    {
        return await _client.GetAsync(url);
    }

    // POST request
    public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
    {
        return await _client.PostAsync(url, content);
    }

    // PUT request
    public async Task<HttpResponseMessage> PutAsync(string url, HttpContent content)
    {
        return await _client.PutAsync(url, content);
    }

    // DELETE request
    public async Task<HttpResponseMessage> DeleteAsync(string url)
    {
        return await _client.DeleteAsync(url);
    }
}
