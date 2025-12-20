
using System;

class SubString
{
   static void Main()
   {
      var letters = "abcdefghijklmabcdefghijklm";

      // invoke Substring method and pass it one parameter
      Console.WriteLine("Substring from index 20 to end is " +
         $"\"{letters.Substring(20)}\"");

      // invoke Substring method and pass it two parameters
      Console.WriteLine("Substring from index 0 of length 6 is " +
         $"\"{letters.Substring(0, 6)}\"");
   }
}
