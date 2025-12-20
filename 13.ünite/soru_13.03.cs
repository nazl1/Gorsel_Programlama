using System;

// Base exception
public class ApplicationExceptionBase : Exception
{
    public ApplicationExceptionBase(string message)
        : base(message) { }
}

// Level 1 derived exception
public class DataException : ApplicationExceptionBase
{
    public DataException(string message)
        : base(message) { }
}

// Level 2 derived exception
public class FileDataException : DataException
{
    public FileDataException(string message)
        : base(message) { }
}

// Level 3 derived exception
public class NetworkFileDataException : FileDataException
{
    public NetworkFileDataException(string message)
        : base(message) { }
}

// Test class
class ExceptionInheritance
{
    static void Main()
    {
        try
        {
            try
            {
                try
                {
                    // Throw most-derived exception
                    throw new NetworkFileDataException(
                        "Network file data error occurred.");
                }
                catch (NetworkFileDataException ex)
                {
                    Console.WriteLine("Caught in inner block:");
                    Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);

                    // Rethrow as base-level exception
                    throw new FileDataException(
                        "File-level problem after network error.");
                }
            }
            catch (FileDataException ex)
            {
                Console.WriteLine("\nCaught in middle block:");
                Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);

                // Rethrow higher in hierarchy
                throw new DataException(
                    "General data error.");
            }
        }
        catch (ApplicationExceptionBase ex)
        {
            Console.WriteLine("\nCaught in outer block:");
            Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nException handling complete.");
        }
    }
}