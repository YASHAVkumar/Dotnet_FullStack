using System.ComponentModel.Design;

namespace TestingConsole.Bussiness.OOPs.Polymorphism;
public class Parent1
{
    public Parent1()
    {
        System.Console.WriteLine("constructor called ");
    }
    public virtual void Method()
    {
        System.Console.WriteLine("parent method called ");
    }
}

public class Child:Parent1
{
    public Child()
    {
        System.Console.WriteLine("constructor called child");
    }
    public override void Method()
    {
        System.Console.WriteLine("child method called ");
    }

}