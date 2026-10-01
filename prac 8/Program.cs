// Constructor and heirarchy
using System;

class A
{
    public A()
    {
        Console.WriteLine("A Default");
    }

    public A(string name) : this()
    {
        Console.WriteLine(name);
    }
}

class B : A
{
    public B() : base("trial")
    {
        Console.WriteLine("B");
    }
}

class Program : B
{
    static void Main()
    {
        Program obj = new Program();
    }
}
