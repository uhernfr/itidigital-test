using System;
using Xunit;
using itidigital.Services.Interfaces;

namespace itidigital.Tests.Unit
{
  public class PasswordServiceTest
  {
    private readonly IPasswordService _passwordService;
    public PasswordServiceTest(IPasswordService passwordService)
    {
      _passwordService = passwordService;
    }

    [Fact]
    public void IsValidPassword_ReturnTrue()
    {
      var value = "AbTp9!fok";
      var ret = _passwordService.IsValidPassword(value);

      Assert.True(ret);

    }

    [Fact]
    public void IsInvalidPassword_ReturnFalse()
    {
      var value = "AAAbbbCc";
      var ret = _passwordService.IsValidPassword(value);

      Assert.False(ret);

    }
  }
}
