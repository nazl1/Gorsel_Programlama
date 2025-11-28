
using System;

class DoWhileTest
{
   static void Main()
   {
      int counter = 1; 

      do
      {
         Console.Write($"{counter}  ");
         ++counter;
      } while (counter <= 10); 

      Console.WriteLine();
   } 
}

