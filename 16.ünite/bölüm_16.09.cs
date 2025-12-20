
using System;
using System.Text;

class StringBuilderConstructor
{
   static void Main()
   {
      var buffer1 = new StringBuilder();
      var buffer2 = new StringBuilder(10);
      var buffer3 = new StringBuilder("hello");

      Console.WriteLine($"buffer1 = \"{buffer1}\"");
      Console.WriteLine($"buffer2 = \"{buffer2}\"");
      Console.WriteLine($"buffer3 = \"{buffer3}\"");
   }
}

