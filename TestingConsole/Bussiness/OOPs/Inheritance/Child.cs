using System.Data;

namespace TestingConsole.Bussiness.OOPs.Inheritance; 
public class Child1(int val) : Parent(val)
{   
    private int _Id=val;
    
    public new void Method()=>System.Console.WriteLine("Child "+_Id);
    public override void  Method1()=>System.Console.WriteLine("Child method1 "+_Id);
}
public sealed class Child2 : ParentAbs
{   
    
    private int _Id;
    public Child2(int val):base(val)
    {
        _Id=val; 
    }
    public new void Method()=>System.Console.WriteLine("Child "+_Id);
    public override void  Method1()=>System.Console.WriteLine("Child method1 "+_Id);
}

public class Child3(int val):IA,IB
{
    private readonly int Id=val;

    int IA.Id { get; set; }
    int IB.Id { get; set; }

    void IA.Method()
    {
       System.Console.WriteLine("Method IA"+this.Id);
    }
    void IB.Method()
    {
        System.Console.WriteLine("Method IB"+ this.Id+ "");
    }
    public void Method1()=>System.Console.WriteLine("Method 1 Child"+ this.Id+ "");
}