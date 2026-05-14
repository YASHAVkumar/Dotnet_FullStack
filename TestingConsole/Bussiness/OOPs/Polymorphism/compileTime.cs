using System.Diagnostics.Contracts;

namespace TestingConsole.Bussiness.OOPs.Polymorphism;
public class Administrator 
{
    public Administrator():this(1)
    {
       System.Console.WriteLine("Constructor called ");  
    }
    public Administrator(int a):this(a,"test")
    {
        System.Console.WriteLine("Constructor1 called");    }
   public Administrator(int a,string b)
    {
        System.Console.WriteLine("Constructor2 called");    }
   public void Method()=>System.Console.WriteLine("method called ");
   public int Method(int vale)=>5;
   public string Method(int val,string val1)=>"rest";

   public void Method(string val,int val1)=>System.Console.WriteLine("test");
   public string Method(string a,string b)=>"test";


   
}
// overloading 
// mehtod with same name but diffrent in sig or param
//diffrent not param 
// sequence change
//signature change


public class Ling
{
    public List<int> lst=[];
    public Ling Where(int y)
    {
        lst = lst.Where(x => x == y).ToList();
        return this;
    }
    public Ling Order()
    {
       lst = lst.OrderBy(x => x).ToList();
        return this;
    }
    public void Select()
    {
        System.Console.WriteLine(string.Join(',',lst.Select(x=>x)));
             
    }

    public class MyLinq<T>
{
    private List<T> data;

    public MyLinq(IEnumerable<T> items)
    {
        data = items.ToList();
    }

    // WHERE
    public MyLinq<T> Where(Func<T, bool> predicate)
    {
        data = data.Where(predicate).ToList();
        return this;
    }

    // ORDER BY
    public MyLinq<T> OrderBy<TKey>(Func<T, TKey> keySelector)
    {
        data = data.OrderBy(keySelector).ToList();
        return this;
    }

    // SELECT
    public MyLinq<TResult> Select<TResult>(Func<T, TResult> selector)
    {
        var result = data.Select(selector).ToList();

        return new MyLinq<TResult>(result);
    }

    // DISPLAY
    public void Print()
    {
        Console.WriteLine(string.Join(", ", data));
    }

    // RETURN LIST
    public List<T> ToList()
    {
        return data;
    }
}
}