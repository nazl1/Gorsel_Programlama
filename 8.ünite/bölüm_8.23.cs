using System;

class ParamArrayTest
{
   static double Average(params double[] numbers)
   {
      var total = 0.0; 

      foreach (var d in numbers)
      {
         total += d;
      }

      return numbers.Length != 0 ? total / numbers.Length : 0.0;
   }

   static void Main()
   {
      var d1 = 10.0;
      var d2 = 20.0;
      var d3 = 30.0;
      var d4 = 40.0;

      Console.WriteLine(
         $"d1 = {d1:F1}\nd2 = {d2:F1}\nd3 = {d3:F1}\nd4 = {d4:F1}\n");
      Console.WriteLine($"Average of d1 and d2 is {Average(d1, d2):F1}");
      Console.WriteLine(
         $"Average of d1, d2 and d3 is {Average(d1, d2, d3):F1}");
      Console.WriteLine(
         $"Average of d1, d2, d3 and d4 is {Average(d1, d2, d3, d4):F1}");
   }
} 