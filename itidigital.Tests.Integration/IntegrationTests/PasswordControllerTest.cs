using itidigital.Tests.Integration.Factory;
using System.Net.Http;
using Xunit;

namespace itidigital.Tests.Integration
{
  public class PasswordControllerTest
  {
    public static HttpClient _client;

    public PasswordControllerTest()
    {
      _client = new HttpClient();
    }


    [Fact]
    public void IsValidPassword_ReturnTrue()
    {
      // Arrange
      var factory = new PasswordControllerFactory();
      
      // Act
      var value = "AbTp9!fok";
      var ret = factory.CheckPasswordPatern(value).Result;
      var content = ret.Content.ReadAsStringAsync().Result;
      
      // Assert
      Assert.True(ret.IsSuccessStatusCode);
      Assert.True(content == "true");

    }

    [Fact]
    public void IsInvalidPassword_ReturnFalse()
    {
      // Arrange
      var factory = new PasswordControllerFactory();

      // Act
      var value = "AAAbbbCc";
      var ret = factory.CheckPasswordPatern(value).Result;
      var content = ret.Content.ReadAsStringAsync().Result;
      
      // Assert
      Assert.True(ret.IsSuccessStatusCode);
      Assert.True(content == "false");

    }
  }
}
