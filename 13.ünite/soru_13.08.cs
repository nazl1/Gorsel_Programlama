using System;

class MissedExceptionsDemo
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Main started.");

            // Method does NOT catch all exceptions
            ProcessData();

            Console.WriteLine("Main finished normally.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Caught in Main:");
            Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Main finally block executed.");
        }
    }

    static void ProcessData()
    {
        try
        {
            Console.WriteLine("ProcessData started.");

            int[] numbers = { 10, 20, 30 };

            // This exception IS caught here
            Console.WriteLine(numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Caught in ProcessData:");
            Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);
        }

        // This exception is NOT caught in this method
        int x = 10;
        int y = 0;
        Console.WriteLine(x / y); // DivideByZeroException (missed here)
    }
}