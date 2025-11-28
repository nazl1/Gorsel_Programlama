using System;

class InitArray
{
  
   static void Main()
   {
     
      int[,] rectangular = {{1, 2, 3}, {4, 5, 6}};

      int[][] jagged = {new int[] {1, 2},
                        new int[] {3},
                        new int[] {4, 5, 6}};

      OutputArray(rectangular); 
      Console.WriteLine(); 
      OutputArray(jagged); 
   }

  
   static void OutputArray(int[,] array)
   {
      Console.WriteLine("Values in the rectangular array by row are");

                                        
      for (var row = 0; row < array.GetLength(0); ++row)
      {
                                 
         for (var column = 0; column < array.GetLength(1); ++column)
         {
            Console.Write($"{array[row, column]}  ");
         }

         Console.WriteLine();              
      }
   }

   static void OutputArray(int[][] array)
   {
      Console.WriteLine("Values in the jagged array by row are");

                              
      foreach (var row in array)
      {    
         foreach (var element in row)
         {
            Console.Write($"{element}  ");
         }

         Console.WriteLine(); 
      }
   }
}