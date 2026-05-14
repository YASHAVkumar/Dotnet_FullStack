using TestingConsole.Bussiness.OOPs.Inheritance;

public partial class Children
{
    public int Id{get;set;}
    public required string Name{get;set;}
    public int Age{get;set;}
    public Parent? Parent{get;set;} 

    public partial void Display();
}

public static class Library
{
    public static readonly int Id;
    static Library()
    {
        Id=90;
    }
    public static void Method()=>System.Console.WriteLine("kya baat");
}

public enum Logs
{
    notset=100,
    one,
    two
}

static class SpName
{
    public static string First="First";
    public const string Second="First";
    //public const DateTime dt = DateTime.Now;  error
    public static readonly DateTime dt = DateTime.Now;
}