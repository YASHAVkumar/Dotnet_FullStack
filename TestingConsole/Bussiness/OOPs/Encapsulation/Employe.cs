using System.Security.AccessControl;

namespace TestingConsole.Bussiness.OOPs.Encapsulation;
public class Employee
{
    private int _id;
    public void SetId(int val)
    {
        _id=val;
    }
    public int GetId()
    {
        return _id;
    }
    public int Id { get{return _id;} set{_id=value;} }

    public int Ids{get;init;}
}