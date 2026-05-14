
using TestingConsole.Bussiness.OOPs.Inheritance;


public partial class Children
{
    public Children()
    {
       // Name="Myra";
        System.Console.WriteLine("Children ctor");
    }
    public virtual Children Method(){System.Console.WriteLine("Method of Children");return this;}

    public partial void Display()
    {
        System.Console.WriteLine($"ID:{Id},Name:{Name},Age:{Age}");
    }
}