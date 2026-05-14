using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace TestingConsole.Bussiness.Fields;
        // Access Modifier and their scope
        // Static Fields 
        // Const Fields 
        // Readonly Fields 
        // Local Constants
public class Admin
{
    public static int Id;
    public string? Name;
    public const string Depart="gses";
    public readonly string DepartExt="Emp";
    static Admin()  // param less static contr to initilaze static fields run only once
    { const int _id=900;
        System.Console.WriteLine(" static contr",_id);
        Id=20;
    }
    public Admin()
    {
        System.Console.WriteLine("class construct");
       DepartExt="gest";
    }

    public static string Method()=>"Hello Myra ";
    public int Ref_Out_IN(out int id, int age,ref string str,in string name,params int[]arg)
    {
        id=90;
        //name="test"; // compile time error
        str="end";
        System.Console.WriteLine(string.Join(',',arg));
        System.Console.WriteLine(" Name of person "+ name);
        
        return age;
    }
    public void ParamDemo(params string[]arg)
    {
        System.Console.WriteLine(string.Join(',',arg));
    }
    //fibbonaci series 0, 1, 1, 2, 3, 5, 8, 13
    public static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    // 5!=5*4*3*2*1
    public static int Factorial(int num)
    {
        if(num==0)
        return 1;
        return num*Factorial(num-1);
    }
}

// | Modifier             | Same Class | Derived Class          | Same Assembly | Outside Assembly |
// | -------------------- | ---------- | ---------------------- | ------------- | ---------------- |
// | `private`            | ✅          | ❌                      | ❌             | ❌                |
// | `protected`          | ✅          | ✅                      | ❌             | Only derived     |
// | `internal`           | ✅          | ✅                      | ✅             | ❌                |
// | `protected internal` | ✅          | ✅                      | ✅             | Derived only     |
// | `private protected`  | ✅          | ✅ (same assembly only) | ❌             | ❌                |
// | `public`             | ✅          | ✅                      | ✅             | ✅                |

//static Fields are belong to same 

// Methods  
//          This keyword
//         Static methods 
//         Parameter Modifier :- ref, in, out, params
//         static local function 
// 		Recursion
