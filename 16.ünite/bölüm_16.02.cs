

using System;

class StringMethods
{
   static void Main()
   {
      var string1 = "hello there";
      var characterArray = new char[5];

      Console.WriteLine($"string1: \"{string1}\""); // output string1

      // test Length property                                     
      Console.WriteLine($"Length of string1: {string1.Length}");

      // loop through characters in string1 and display reversed
      Console.Write("The string reversed is: ");

      for (int i = string1.Length - 1; i >= 0; --i)
      {
         Console.Write(string1[i]);
      }

      // copy characters from string1 into characterArray           
      string1.CopyTo(0, characterArray, 0, characterArray.Length);
      Console.Write("\nThe character array is: ");

      foreach (var element in characterArray)
      {
         Console.Write(element);
      }

      Console.WriteLine("\n");
   }
}
