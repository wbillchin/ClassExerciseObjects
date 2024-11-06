using System;

public class BaseClass
{
    public BaseClass(int number)
    {
        Console.WriteLine($"Base class constructor with number: {number}");
    }
}

public class DerivedClass : BaseClass
{
    public DerivedClass(int number) : base(number)
    {
        Console.WriteLine("Derived class constructor");
    }
}

