
using System;

class DivideByZeroExceptionHandling
{
   static void Main(string[] args)
   {
      var continueLoop = true; // determines whether to keep looping

      do
      {
         // retrieve user input and calculate quotient                   
         try
         {
            // int.Parse generates FormatException                    
            // if argument cannot be converted to an integer          
            Console.Write("Enter an integer numerator: ");
            var numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            // division generates DivideByZeroException               
            // if denominator is 0                                    
            var result = numerator / denominator;

            // display result                                         
            Console.WriteLine(
               $"\nResult: {numerator} / {denominator} = {result}");
            continueLoop = false;
         }
         catch (FormatException formatException)
         {
            Console.WriteLine($"\n{formatException.Message}");
            Console.WriteLine(
               "You must enter two integers. Please try again.\n");
         }
         catch (DivideByZeroException divideByZeroException)
         {
            Console.WriteLine($"\n{divideByZeroException.Message}");
            Console.WriteLine(
               "Zero is an invalid denominator. Please try again.\n");
         }
      } while (continueLoop);
   }
}

