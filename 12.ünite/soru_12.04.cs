class Base
{
    public virtual void Process() { }
}

class Derived : Base
{
    public sealed override void Process() { }
}

class MoreDerived : Derived
{
    // override edilemez
}