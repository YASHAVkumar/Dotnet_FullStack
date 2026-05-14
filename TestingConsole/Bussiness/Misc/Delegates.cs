public delegate void MyDelegate(string message);
public delegate void MyDelegate1<T>(params T[] args);
public class DelegatesExample
{
    public static void Method(string msg)=>System.Console.WriteLine($"first delegate func,:{msg}");
    public static void Method1(string msg)=>System.Console.WriteLine($"second delegate func,:{msg}");
    public static void Method3<T>(params T[] args){
        foreach(var item in args)
        {
            System.Console.WriteLine(item);
        }
    }
}