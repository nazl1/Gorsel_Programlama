
using System;

class DivideByZeroNoExceptionHandling
{
   static void Main()
   {
      // get numerator
      Console.Write("Please enter an integer numerator: ");
      var numerator = int.Parse(Console.ReadLine());

      // get denominator
      Console.Write("Please enter an integer denominator: ");
      var denominator = int.Parse(Console.ReadLine());

      // divide the two integers, then display the result
      var result = numerator / denominator;
      Console.WriteLine(
         $"\nResult: {numerator} / {denominator} = {result}");
   }
}
