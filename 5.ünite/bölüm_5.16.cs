
using System;

class Increment
{
   static void Main()
   {
      
      int c = 5; 
      Console.WriteLine($"c before postincrement: {c}"); 
      Console.WriteLine($"    postincrementing c: {c++}"); 
      Console.WriteLine($" c after postincrement: {c}"); 

      Console.WriteLine(); 
      
      c = 5; 
      Console.WriteLine($" c before preincrement: {c}"); 
      Console.WriteLine($"     preincrementing c: {++c}"); 
      Console.WriteLine($"  c after preincrement: {c}"); 
   }
} 
