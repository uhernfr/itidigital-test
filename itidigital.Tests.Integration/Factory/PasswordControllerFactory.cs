using System.Net.Http;
using System.Threading.Tasks;

namespace itidigital.Tests.Integration.Factory
{
  public class PasswordControllerFactory
  {
    private const string url = @"https://localhost:5001/v1/Password/validate";

    private readonly HttpClient _client;
    public PasswordControllerFactory()
    {
      _client = new HttpClient();
    }

    public Task<HttpResponseMessage> CheckPasswordPatern(string password)
    {           
      var multiForm = new MultipartFormDataContent();
      multiForm.Add(new StringContent(password), "password");
      
      var response = _client.PostAsync(url, multiForm);
      
      return response;
    }
  }
}
