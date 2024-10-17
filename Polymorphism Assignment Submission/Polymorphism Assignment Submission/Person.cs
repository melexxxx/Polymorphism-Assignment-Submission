// Person.cs
using System;

// Abstract class Person, meant to be inherited by other classes
public abstract class Person
{
    // Properties for the first and last name
    public string firstName { get; set; }
    public string lastName { get; set; }

    // Abstract method to be implemented by derived classes
    public abstract void SayName();
}
