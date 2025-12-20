
using System;

class StringIndexMethods
{
   static void Main()
   {
      var letters = "abcdefghijklmabcdefghijklm";
      char[] searchLetters = {'c', 'a', '$'};

      // test IndexOf to locate a character in a string
      Console.WriteLine($"First 'c' is located at index " +
          letters.IndexOf('c'));
      Console.WriteLine("First 'a' starting at 1 is located at index " +
         letters.IndexOf('a', 1));
      Console.WriteLine("First '$' in the 5 positions starting at 3 " +
         $"is located at index " + letters.IndexOf('$', 3, 5));

      // test LastIndexOf to find a character in a string
      Console.WriteLine($"\nLast 'c' is located at index " +
         letters.LastIndexOf('c'));
      Console.WriteLine("Last 'a' up to position 25 is located at " +
         "index " + letters.LastIndexOf('a', 25));
      Console.WriteLine("Last '$' in the 5 positions ending at 15 " +
         "is located at index " + letters.LastIndexOf('$', 15, 5));

      // test IndexOf to locate a substring in a string
      Console.WriteLine("\nFirst \"def\" is located at index " +
         letters.IndexOf("def"));
      Console.WriteLine("First \"def\" starting at 7 is located at " +
         "index " + letters.IndexOf("def", 7));
      Console.WriteLine("First \"hello\" in the 15 positions " +
         "starting at 5 is located at index " +
         letters.IndexOf("hello", 5, 15));

      // test LastIndexOf to find a substring in a string
      Console.WriteLine("\nLast \"def\" is located at index " +
         letters.LastIndexOf("def"));
      Console.WriteLine("Last \"def\" up to position 25 is located " +
         "at index " + letters.LastIndexOf("def", 25));
      Console.WriteLine("Last \"hello\" in the 15 positions " +
         "ending at 20 is located at index " +
         letters.LastIndexOf("hello", 20, 15));

      // test IndexOfAny to find first occurrence of character in array
      Console.WriteLine("\nFirst 'c', 'a' or '$' is " +
         "located at index " + letters.IndexOfAny(searchLetters));
      Console.WriteLine("First 'c', 'a' or '$' starting at 7 is " +
         "located at index " + letters.IndexOfAny(searchLetters, 7));
      Console.WriteLine("First 'c', 'a' or '$' in the 5 positions " +
         "starting at 7 is located at index " +
         letters.IndexOfAny(searchLetters, 7, 5));

      // test LastIndexOfAny to find last occurrence of character
      // in array
      Console.WriteLine("\nLast 'c', 'a' or '$' is " +
         "located at index " + letters.LastIndexOfAny(searchLetters));
      Console.WriteLine("Last 'c', 'a' or '$' up to position 1 is " +
         "located at index " +
         letters.LastIndexOfAny(searchLetters, 1));
      Console.WriteLine("Last 'c', 'a' or '$' in the 5 positions " +
         "ending at 25 is located at index " +
         letters.LastIndexOfAny(searchLetters, 25, 5));
   }
}
