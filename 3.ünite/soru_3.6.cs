 using System;
 class Product
 {
    static void Main()
    {
      int x; 
      int y; 
       int z; 
       int result; 
 
       Console.Write("Enter first integer: "); 
       x = int.Parse(Console.ReadLine()); 
 
       Console.Write("Enter second integer: "); 
       y = int.Parse(Console.ReadLine()); 
 
       Console.Write("Enter third integer: "); 
       z = int.Parse(Console.ReadLine()); 
 
       result = x * y * z; 
       Console.WriteLine($"Product is {result}");
    } 
  } 