
using System;

public class NegativeNumberException : Exception
{
   // default constructor                                
   public NegativeNumberException()
      : base("Illegal operation for a negative number")
   {
      // empty body                                      
   }

   // constructor for customizing error message         
   public NegativeNumberException(string messageValue)
      : base(messageValue)
   {
      // empty body                                     
   }

   // constructor for customizing the exception's error
   // message and specifying the InnerException object 
   public NegativeNumberException(string messageValue, Exception inner)
      : base(messageValue, inner)
   {
      // empty body                                    
   } 
}
