
using System;

class StaticCharMethods
{
   static void Main(string[] args)
   {
      Console.Write("Enter a character: ");
      var character = char.Parse(Console.ReadLine());

      Console.WriteLine($"is digit: {char.IsDigit(character)}");
      Console.WriteLine($"is letter: {char.IsLetter(character)}");
      Console.WriteLine(
         $"is letter or digit: {char.IsLetterOrDigit(character)}");
      Console.WriteLine($"is lower case: {char.IsLower(character)}");
      Console.WriteLine($"is upper case: {char.IsUpper(character)}");
      Console.WriteLine($"to upper case: {char.ToUpper(character)}");
      Console.WriteLine($"to lower case: {char.ToLower(character)}");
      Console.WriteLine(
         $"is punctuation: {char.IsPunctuation(character)}");
      Console.WriteLine($"is symbol: {char.IsSymbol(character)}");
   }
}
