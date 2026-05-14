//base keyword, sealed classes, sealed methods 
//operators overloading  adding two object 

public class Teachers
{  
    public virtual void Method3()=> System.Console.WriteLine("call sealed method"); 
}

public class Student:Teachers
{
    public int Marks;
    public Student(int v)
    {
        Marks = v;
    }
    public sealed override void Method3()=> System.Console.WriteLine("call sealed method"); 
    
    public static bool operator >(Student a, Student b)
    {
        return a.Marks > b.Marks;
    }

    public static bool operator <(Student a, Student b)
    {
        return a.Marks < b.Marks;
    }
}
