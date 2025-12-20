
using System;
using System.Text;

class StringBuilderAppendFormat
{
   static void Main()
   {
      var buffer = new StringBuilder();

      // formatted string                         
      var string1 = "This {0} costs: {1:C}.\n\n";

      // string1 argument array              
      var objectArray = new object[2] { "car", 1234.56 };

      // append to buffer formatted string with argument
      buffer.AppendFormat(string1, objectArray);

      // formatted string                              
      string string2 = "Number:\n{0:d3}.\n\n" +
         "Number right aligned with spaces:\n{0,4}.\n\n" +
         "Number left aligned with spaces:\n{0,-4}.";

      // append to buffer formatted string with argument
      buffer.AppendFormat(string2, 5);

      // display formatted strings
      Console.WriteLine(buffer.ToString());
   }
}
