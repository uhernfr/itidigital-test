using itidigital.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itidigital_test.Controllers
{
  [ApiController]
  [Route("v1/[controller]")]
  public class PasswordController : ControllerBase
  {
    private readonly ILogger<PasswordController> _logger;
    private readonly IPasswordService _passwordService;

    public PasswordController(ILogger<PasswordController> logger, IPasswordService passwordService)
    {
      _logger = logger;
      _passwordService = passwordService;
    }


    [Route("validate")]
    [HttpPost]
    public IActionResult validate([FromForm] string password)
    {
      if (string.IsNullOrEmpty(password))
      {
        return BadRequest();
      }
      
      bool ret = _passwordService.IsValidPassword(password);
      return Ok(ret);
    }
  }
}
