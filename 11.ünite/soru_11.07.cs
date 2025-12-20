class BaseClass
{
    public BaseClass(int x)
    {
        Console.WriteLine("BaseClass constructor: " + x);
    }
}

class DerivedClass : BaseClass
{
    public DerivedClass() : base(10)
    {
        Console.WriteLine("DerivedClass constructor");
    }
}