using System;

class InitArray
{
   static void Main()
   {
     
      int[] array = { 32, 27, 64, 18, 95 };

      Console.WriteLine($"{"Index"}{"Value",8}"); 

      for (int counter = 0; counter < array.Length; ++counter)
      {
         Console.WriteLine($"{counter,5}{array[counter],8}");
      }
   }
}
