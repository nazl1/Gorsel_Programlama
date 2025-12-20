
using System;

class Properties
{
   static void Main()
   {
      // call Method1; any Exception generated is caught
      // in the catch block that follows
      try
      {
         Method1();
      }
      catch (Exception exceptionParameter)
      {
         // output the string representation of the Exception, then output
         // properties Message, StackTrace and InnerException
         Console.WriteLine("exceptionParameter.ToString: \n" +
            exceptionParameter);
         Console.WriteLine("\nexceptionParameter.Message: \n" +
            exceptionParameter.Message);
         Console.WriteLine("\nexceptionParameter.StackTrace: \n" +
            exceptionParameter.StackTrace);
         Console.WriteLine("\nexceptionParameter.InnerException: \n" +
            exceptionParameter.InnerException);
      }
   }

   // calls Method2
   static void Method1()
   {
      Method2();
   }

   // calls Method3
   static void Method2()
   {
      Method3();
   }

   // throws an Exception containing an InnerException
   static void Method3()
   {
      // attempt to convert string to int
      try
      {
         int.Parse("Not an integer");
      }
      catch (FormatException formatExceptionParameter)
      {
         // wrap FormatException in new Exception
         throw new Exception("Exception occurred in Method3",
            formatExceptionParameter);
      }
   }
}
