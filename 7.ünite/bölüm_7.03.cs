
using System;

class MaximumFinder
{
   
   static void Main()
   {
      
      Console.Write("Enter first floating-point value: ");
      double number1 = double.Parse(Console.ReadLine());
      Console.Write("Enter second floating-point value: ");
      double number2 = double.Parse(Console.ReadLine());
      Console.Write("Enter third floating-point value: ");
      double number3 = double.Parse(Console.ReadLine());

      
      double result = Maximum(number1, number2, number3);

      
      Console.WriteLine("Maximum is: " + result);
   }

             
   static double Maximum(double x, double y, double z)
   {
      double maximumValue = x; 

              
      if (y > maximumValue)
      {
         maximumValue = y;
      }

           
      if (z > maximumValue)
      {
         maximumValue = z;
      }

      return maximumValue;
   }
}


