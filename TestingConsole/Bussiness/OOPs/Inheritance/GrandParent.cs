using System.Data;

namespace TestingConsole.Bussiness.OOPs.Inheritance; 
public class GrandParent(int val)
{   
    private int _Id = val;
    public void Method()=>System.Console.WriteLine("GP "+_Id);
}