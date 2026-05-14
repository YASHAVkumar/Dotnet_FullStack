public static class Utility
{
    public static string Method(this int var)
    {
        return Convert.ToString(var);
    }
}
public class Test
{
    public int t=90;
    public class Test1
    {
        public string str="innner class";
    }
}