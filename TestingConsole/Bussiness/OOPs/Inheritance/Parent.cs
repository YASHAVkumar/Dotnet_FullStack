using System.Data;

namespace TestingConsole.Bussiness.OOPs.Inheritance; 
public class Parent(int val)
{   
    private int _Id = val;
    public void Method()=>System.Console.WriteLine("Parent "+_Id);
    public virtual void Method1()=>System.Console.WriteLine("Parent Method1 ");
}

public abstract class ParentAbs
{
   private int _Id;
   public ParentAbs(int val)
   {
     System.Console.WriteLine("ctor called ParentAbs");
     _Id=val;
   }
   public void Method()=>System.Console.WriteLine("Parent ABs"+_Id);  
   public abstract void Method1(); 
}

public interface IA
{
    public int Id{get;set;}
    public void Method();
    public void Method1();
}
public interface IB
{
    public int Id{get;set;}
    public void Method();
}