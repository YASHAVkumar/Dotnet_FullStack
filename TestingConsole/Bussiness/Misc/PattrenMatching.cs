using System.Data;

class Person
{
    public int Id{get;set;}
    public string Name{get;set;}
    public static void Method()
    {
        object obj = "Hello";

        if (obj is string st)  //Type Pattern
        {
            Console.WriteLine(st.Length);
        }

        //Switch Case Pattern
switch(obj)
{
    case int x when x>10:
        Console.WriteLine($"Int {x}");
        break;

    case string s:
        Console.WriteLine($"String {s}");
        break;
}

int age = 25;

bool result = age is > 18 and < 60; //Logical Patterns

    }
    public void Deconstruct(
        out int id,
        out string name)
    {
        id = Id;
        name = Name;
    }
}