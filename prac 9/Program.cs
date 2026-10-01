// inheritence, constructors and constructor chaining
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

/* override
 * using System;

class A
{
    public virtual void Display()
    {
        Console.WriteLine("A");
    }
}

class B : A
{
    public override void Display()
    {
        Console.WriteLine("B");
    }
}

class Program
{
    static void Main()
    {
        A obj = new B(); // base reference, child object
        obj.Display();   // calls B's override
    }
}
*/