using System;

class RollDie
{
   static void Main()
   {
      var randomNumbers = new Random(); 
      var frequency = new int[7];

      for (var roll = 1; roll <= 60000000; ++roll)
      {
         ++frequency[randomNumbers.Next(1, 7)];
      }

      Console.WriteLine($"{"Face"}{"Frequency",10}");

      
      for (var face = 1; face < frequency.Length; ++face)
      {
         Console.WriteLine($"{face,4}{frequency[face],10}");
      }
   }
} 
