

using System;

class StringMethods2
{
   static void Main()
   {
      var string1 = "cheers!";
      var string2 = "GOOD BYE ";
      var string3 = "   spaces   ";

      Console.WriteLine($"string1 = \"{string1}\"\n" +
         $"string2 = \"{string2}\"\n" +
         $"string3 = \"{string3}\"");

      // call method Replace
      Console.WriteLine("\nReplacing \"e\" with \"E\" in string1: " +
         $"\"{string1.Replace('e', 'E')}\"");

      // call ToLower and ToUpper
      Console.WriteLine(
         $"\nstring1.ToUpper() = \"{string1.ToUpper()}\"" +
         $"\nstring2.ToLower() = \"{string2.ToLower()}\"");

      // call Trim method
      Console.WriteLine(
         $"\nstring3 after trim = \"{string3.Trim()}\"");

      Console.WriteLine($"\nstring1 = \"{string1}\"");
   }
}
