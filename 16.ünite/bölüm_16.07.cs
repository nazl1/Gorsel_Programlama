
using System;

class StringConcatenation
{
   static void Main()
   {
      var string1 = "Happy ";
      var string2 = "Birthday";

      Console.WriteLine($"string1 = \"{string1}\"");
      Console.WriteLine($"string2 = \"{string2}\"");
      Console.WriteLine("\nResult of string.Concat(string1, string2) = " +
         string.Concat(string1, string2));
      Console.WriteLine($"string1 after concatenation = {string1}");
   }
}
