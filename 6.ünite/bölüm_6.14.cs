
using System;

class ContinueTest
{
   static void Main()
   {
      for (int count = 1; count <= 10; ++count) 
      {
         if (count == 5) 
         {
            continue; 
         }

         Console.Write($"{count} ");
      }

      Console.WriteLine("\nUsed continue to skip displaying 5");
   }
}

