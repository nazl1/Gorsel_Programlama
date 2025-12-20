
using System;

class StringStartEnd
{
   static void Main()
   {
      string[] strings = { "started", "starting", "ended", "ending" };

      // test every string to see if it starts with "st"
      foreach (var element in strings)
      {
         if (element.StartsWith("st"))
         {
            Console.WriteLine($"\"{element}\" starts with \"st\"");
         }
      }

      Console.WriteLine();

      // test every string to see if it ends with "ed"
      foreach (var element in strings)
      {
         if (element.EndsWith("ed"))
         {
            Console.WriteLine($"\"{element}\" ends with \"ed\"");
         }
      }

      Console.WriteLine();
   }
}
