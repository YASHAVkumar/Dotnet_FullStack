using System.Runtime.CompilerServices;
using TestingConsole.Bussiness.OOPs.Inheritance;

public struct Area:IA
{
   public int x;
    int y;
    public Area()
    {
       x=89; 
       y=100;
       System.Console.WriteLine("ctor area");
    }

    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Method()=>System.Console.WriteLine("struct method");

    public void Method1()
    {
        throw new NotImplementedException();
    }
}

readonly struct Employees
{
    public readonly int Id;

    public Employees(int id)
    {
        Id = id;
    }
}

ref struct Point
{
    ref int x;
    ref int y;
    public void Method()=>System.Console.WriteLine("testing");
    public int Method1()=>55;
}