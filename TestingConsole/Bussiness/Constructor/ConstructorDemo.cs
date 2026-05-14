// 8. Constructor -- Instance,static, private, overloading, object initializer, chaining
public class ConstructorDemo
{
   public readonly static int str=99;
   private string _name;
   public string Name{get=>_name;set=>_name=value.Trim();}
   private int _Id;
    public int Id
    {
        get => field;
        set
        {
            if (value == 0)
                field = 1; field = value;
        }
    }
    public ConstructorDemo():this("name")
    {
        
    }
    static ConstructorDemo()
    {
        str++;
    }
    private ConstructorDemo(string str)
    {
        Name=str;
        _Id=80;
    }
}