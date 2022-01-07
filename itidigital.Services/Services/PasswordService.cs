using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace itidigital.Services.Interfaces
{
  public class PasswordService :IPasswordService
  {
    public bool IsValidPassword(string password)
    {
      if (CheckPattern(password) && CheckPatternRepeat(password))
          return true;

      return false;
    }

    private bool CheckPattern(string password)
    {
      string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{9,}$";

      MatchCollection matches = Regex.Matches(password, pattern,
                                              RegexOptions.IgnorePatternWhitespace);
      return matches.Count > 0;
    }

    private bool CheckPatternRepeat(string password)
    {
      var chars = password.ToCharArray().ToList();
      foreach (var item in chars)
      {
        if (chars.Where(x => x == item).Count() > 1)
          return false;
      }
      
      return true;

    }
  }
}
