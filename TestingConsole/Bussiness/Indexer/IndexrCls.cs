public class IndexerCls
{
    //Indexers allow objects to be accessed like arrays.
    private string[] number= { "A", "B", "C" };
    public string this[int indx]
    {
        get=>number[indx];
        set=>number[indx]=value;
    }
    public string this[string val]
    {
        get=>Convert.ToString(number.First(x=>x==val));
    }
}