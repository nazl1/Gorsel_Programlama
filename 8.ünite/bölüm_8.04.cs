using System;

class InitArray
{
   static void Main()
   {
      const int ArrayLength = 5; 
      int[] array = new int[ArrayLength];

     
      for (int counter = 0; counter < array.Length; ++counter)
      {
         array[counter] = 2 + 2 * counter;
      }

      Console.WriteLine($"{"Index"}{"Value",8}"); 

      for (int counter = 0; counter < array.Length; ++counter)
      {
         Console.WriteLine($"{counter,5}{array[counter],8}");
      }
   }
}
