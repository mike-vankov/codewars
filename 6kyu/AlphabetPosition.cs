using System;
using System.Linq;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    return string.Join(" ",text.Select(c=>char.IsLetter(c)?((int)char.ToUpper(c)-64).ToString():string.Empty).Where(c=>c!=string.Empty).ToArray());
  }
}