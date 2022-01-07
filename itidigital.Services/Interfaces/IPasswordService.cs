using System;
using System.Collections.Generic;
using System.Text;

namespace itidigital.Services.Interfaces
{
  public interface IPasswordService
  {
    bool IsValidPassword(string password);
  }
}
