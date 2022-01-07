using itidigital.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace itidigital.Tests.Unit
{
  public class Startup
  {  
    public void ConfigureServices(IServiceCollection services)
    {   
      services.AddSingleton<IPasswordService, PasswordService>();
    }

  }
}
