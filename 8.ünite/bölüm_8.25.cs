using System;

class ArrayReferenceTest
{
   static void Main()
   {
      int[] firstArray = { 1, 2, 3 };

     
      int[] firstArrayCopy = firstArray;

      Console.WriteLine("Test passing firstArray reference by value");
      Console.Write(
         "Contents of firstArray before calling FirstDouble:\n\t");

      foreach (var element in firstArray)
      {
         Console.Write($"{element} ");
      }

      FirstDouble(firstArray);

      Console.Write(
         "\nContents of firstArray after calling FirstDouble\n\t");

      foreach (var element in firstArray)
      {
         Console.Write($"{element} ");
      }

      if (firstArray == firstArrayCopy)
      {
         Console.WriteLine("\n\nThe references refer to the same array");
      }
      else
      {
         Console.WriteLine(
            "\n\nThe references refer to different arrays");
      }

      int[] secondArray = { 1, 2, 3 };

     
      int[] secondArrayCopy = secondArray;

      Console.WriteLine(
         "\nTest passing secondArray reference by reference");
      Console.Write(
         "Contents of secondArray before calling SecondDouble:\n\t");

      
      foreach (var element in secondArray)
      {
         Console.Write($"{element} ");
      }

     
      SecondDouble(ref secondArray);

      Console.Write(
         "\nContents of secondArray after calling SecondDouble:\n\t");

      
      foreach (var element in secondArray)
      {
         Console.Write($"{element} ");
      }

      // test whether reference was changed by SecondDouble
      if (secondArray == secondArrayCopy)
      {
         Console.WriteLine("\n\nThe references refer to the same array");
      }
      else
      {
         Console.WriteLine(
            "\n\nThe references refer to different arrays");
      }
   }

 
   static void FirstDouble(int[] array)
   {
                             
      for (var i = 0; i < array.Length; ++i)
      {
         array[i] *= 2;
      }

      array = new int[] { 11, 12, 13 };
   }
                         
   static void SecondDouble(ref int[] array)
   {                    
      for (var i = 0; i < array.Length; ++i)
      {
         array[i] *= 2;
      }

      array = new int[] { 11, 12, 13 };
   }
}