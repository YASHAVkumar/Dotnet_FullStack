
// Generics in C#

// Generics allow us to create:

// classes
// methods
// interfaces

//Generic Syntax
// class Test<T>
// {
//     public T Data;
// }

//Generic Method
// class Program
// {
//     static void Print<T>(T data)
//     {
//         Console.WriteLine(data);
//     }

//     static void Main()
//     {
//         Print<int>(10);
//         Print<string>("Myra");
//     }
// }

//Multiple Generic Types
// class Data<T1, T2>
// {
//     public T1 Id;
//     public T2 Name;
// }


// Generic Constraints

// Constraints restrict what types can be used.
// where T : class  Only reference types allowed.
 class TestCls<T> where T : class
 {
 }

//where T : struct Only value types allowed.
// class Test<T> where T : struct
// {
// }

//where T : new() Requires parameterless constructor.
class Test<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}

//where T : BaseClass
// class Test<T> where T : Employee
// {
// }

//where T : interface
// class Test<T> where T : IDisposable
// {
// }

//Generic Interface
// interface IRepository<T>
// {
//     void Add(T item);
// }

//Generic Delegate
// Func<int, int, int> add =
//     (a, b) => a + b;

//1. Type Safety
//2. Better Performance No boxing/unboxing.
//3. Reusability One code works for multiple types.


//Covariance out and Contravariance in

// interface IRepository<out T>
// {
// }

// List<Dog> dogs = new List<Dog>();

// // List<Animal> animals = dogs; ❌ Error
//Because generics are invariant by default.

// 1. Covariance (out)

// Covariance allows:

// derived type → base type conversion
// Used for output/read-only scenarios.

// class Animal
// {
// }

// class Dog : Animal
// {
// }

// IEnumerable<Dog> dogs =
//     new List<Dog>();

// IEnumerable<Animal> animals = dogs;

//////////////////////////////////

// 2. Contravariance (in)

// Contravariance allows:

// base type → derived type conversion

// Used for input/write-only scenarios.
// class Animal
// {
// }

// class Dog : Animal
// {
// }

// Action<Animal> act =
//     a => Console.WriteLine("Animal");

// Action<Dog> dogAct = act;