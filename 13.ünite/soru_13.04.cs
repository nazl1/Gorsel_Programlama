using System;

// Base exception
class BaseAppException : Exception
{
    public BaseAppException(string message) : base(message) { }
}

// Derived exceptions
class DerivedExceptionA : BaseAppException
{
    public DerivedExceptionA(string message) : base(message) { }
}

class DerivedExceptionB : DerivedExceptionA
{
    public DerivedExceptionB(string message) : base(message) { }
}

// Demonstration class
class VariousExceptionsCatch
{
    static void Main()
    {
        try
        {
            // Throw the most-derived exception
            throw new DerivedExceptionB("DerivedExceptionB thrown.");
        }
        // OUT OF BOUNDS: base-class catch placed before derived-class catch
        catch (BaseAppException ex)
        {
            Console.WriteLine("Caught in BaseAppException catch:");
            Console.WriteLine(ex.GetType().Name + " -> " + ex.Message);
        }
        // This block is unreachable and causes a compile-time error
        catch (DerivedExceptionB ex)
        {
            Console.WriteLine("Caught in DerivedExceptionB catch:");
            Console.WriteLine(ex.Message);
        }
    }
}