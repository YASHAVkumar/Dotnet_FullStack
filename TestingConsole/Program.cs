
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using TestingConsole.Bussiness.Fields;
using TestingConsole.Bussiness.OOPs.Encapsulation;
using TestingConsole.Bussiness.OOPs.Inheritance;
using TestingConsole.Bussiness.OOPs.Polymorphism;
using static TestingConsole.Bussiness.OOPs.Polymorphism.Ling;
using Alias = TestingConsole.Bussiness;


//NewMethod();

//NewMethod1();

//NewMethod2();

//await NewMethod3();

//NewMethod4();


//ThreadingMethod();

TaskLibrary();


static void NewMethod()
{
    int[] number = [1, 2, 3, 4, 3];
    List<int> lst = [];
    foreach (var i in number)
        if (!lst.Contains(i))
            lst.Add(i);
    Employee ex = new() { Ids = 68 };


    Parent parent = new(79);
    parent.Method();
    parent.Method1();

    Child1 child1 = new(90);
    child1.Method();
    child1.Method1();

    Child2 child2 = new(20);
    child2.Method();
    child2.Method1();

    ParentAbs parentAbs = new Child2(30);
    parentAbs.Method();
    //  Child2 class
    //  public new void Method()=>System.Console.WriteLine("Child "+_Id);
    //  ParentAbs parentAbs=new Child2(30);
    // 	parentAbs.Method();
    //   Static Binding / Early Binding compile time 
    parentAbs.Method1();
    //parentAbs.Method1()
    // Actual object type = Child2
    // ↓
    // vtable lookup
    // ↓
    // Child2.Method1()
    //RUN TIME 

    Child3 child3 = new(100);
    child3.Method1();

    IA ia = new Child3(21);
    ia.Method();
    ia.Method1();

    IB ib = new Child3(22);
    ib.Method();
    System.Console.WriteLine("=============");

    Administrator administrator = new();
    administrator.Method();
    administrator.Method(23);
    administrator.Method(56, "test1");

    Console.WriteLine("Hello, World! ");

    System.Console.WriteLine("=============");

    // Ling ling=new();
    // ling.lst=[9,2,4,5,7];
    // ling.Order().Select();

    MyLinq<int> numbers = new MyLinq<int>(
        [9, 2, 4, 5, 7, 5]
    );

    // numbers
    //     .Where(x => x > 4)
    //     .OrderBy(x => x)
    //     .Print();

    var result = numbers
                    .Where(x => x > 2)
                    .Select(x => $"Number: {x}");

    result.Print();

    Parent1 obj = new Child();
    obj.Method();

    System.Console.WriteLine("==================");

    Admin d = new()
    {
        Name = "test"
    };
    Admin t = new()
    {
        Name = "fand"   // instance field Each object gets separate copy.
    };

    //Admin.Id=90; //Only one copy shared by all objects.


    //System.Console.WriteLine(Admin.Method());
    int n;
    string name = "start";
    d.Ref_Out_IN(out n, 22, ref name, in name, 47649, 53, 3);

    for (int i = 0; i < 8; i++)
        System.Console.WriteLine(Admin.Fibonacci(i) + " ");

    System.Console.WriteLine(Admin.Factorial(5) + " ");
}

static void NewMethod1()
{
    //Unboxing:Converting the object back to the original value type.
    Object lets = 90;
    int i = (int)lets;
    System.Console.WriteLine(i);
    // boxing :-Converting a value type into an object.
    int jack = 50;
    Object lts = jack;

    // parse and tryparse
    List<string> strArr = ["my", "self", "yashav"];
    System.Console.WriteLine(int.TryParse(strArr.ElementAt(0), out int trs));

    ConstructorDemo constructorDemo = new() { Name = "riya" };


    System.Console.WriteLine(ConstructorDemo.str + " " + constructorDemo.Name);
}

static void NewMethod2()
{
    IndexerCls indexerCls = new();
    Console.WriteLine(indexerCls[1] + " " + indexerCls["B"]);
    Alias.Employee emp = new();
    Alias.Nested.Employee emps = new();

    Children children = new() { Id = 1, Name = "Myra", Age = 18, Parent = new Parent(78) };
    children.Method().Display();

    System.Console.WriteLine("Hello Myra " + Library.Id + "");
    Library.Method();

    System.Console.WriteLine(SpName.First = "klol");

    Area area = new() { x = 88 };
    area.Method();

    Span<int> numbers = stackalloc int[5];
    System.Console.WriteLine(numbers[0]);
}

static async Task NewMethod3()
{
    Collectionss collection = new();
    collection.array = [2, 4, 6, 8, 9, "test", "myra", 0.9];
    collection.hashtable.Add(1, 35);
    collection.hashtable.Add(3, "rest");
    //collection.hashtable.Add(null,"test");
    collection.hashtable.Add(2, 0.9);
    // foreach(var item in collection.hashtable)
    // {
    //     System.Console.WriteLine(item);
    // }



    //List , Dictonary, Stack ,Queue,Hashset,LinkedList
    List<int> lst = [1, 2, 34, 5];

    //lst.BinarySearch(2);
    Dictionary<int, string> keyValuePairs = [];
    keyValuePairs.Add(1, "ks");

    HashSet<string> hs = new(9)
{
    null,
    "s",
    "s",
    "g",
    "a"
};

    LinkedList<int> ls = new();
    ls.AddFirst(10);
    ls.AddLast(20);
    ls.AddFirst(30);

    SortedList<int, string> slst = new()
{
    { 1, "test" },
    { 4, "klle" },
    { 3, "kleks" }
};


    ConcurrentDictionary<int, string> cd = new();

    cd.TryAdd(1, "Myra");
    cd.AddOrUpdate(
        1,
        "New",
        (key, oldValue) => "Updated");

    Parallel.For(0, 100, x =>
    {
        cd.TryAdd(x, "one");
    });



    ConcurrentDictionary<int, int> data =
           new ConcurrentDictionary<int, int>();

    List<Task> tasks = new List<Task>();

    for (int i = 0; i < 10000; i++)
    {
        int x = i;

        tasks.Add(Task.Run(() =>
        {
            data[x] = x;
        }));
    }

    await Task.WhenAll(tasks);

    //         Console.WriteLine(data.Count);
    // foreach (var item in tasks)
    // {
    //     System.Console.WriteLine(item.Id);
    // }

    ICollection<int> collection1 = [];
    TestCls<Child> cls = new();
    Test<Child> ts = new();

    Person person = new()
    {
        Id = 1,
        Name = "Mrinu"
    };

    var result = person switch  // Property pattern
    {
        { Id: _, Name: "test" } => "first",
        { Id: 1, Name: "Mrinu" } => "Second",
        { Id: 2, Name: "k" } => "Thrid",
        _ => ""
    };

    int marks = 85;

    string grade = marks switch
    {
        >= 90 => "A+",
        >= 75 => "A",
        >= 60 => "B",
        _ => "Fail"
    };

    Tuple<int, string> t = new(44, "tst");

    (string, int) s = ("tst", 90);

    var r = t switch
    {
        (1, "test") => 1,
        (79, "ll") => 3,
        (_, _) => 2,
        _ => 0
    };


    //Type Pattern Example
    object obj = 10;

    string op = obj switch
    {
        int x => $"Integer {x}",
        string st => $"String {st}",
        _ => "Unknown"
    };

    Expression<Func<int, int>> expr = x => x * x;

    //db.Users.Where(x => x.Id == 1); Expression<Func<User, bool>>
    Range fruit = 1..4;
    int[,] multiDimesion = new int[4, 4];
    int[][] jagged =
    [
        [1,3,4],
    [1,2]
    ];
    // foreach(var row in jagged)
    // {
    //     foreach(var item in row)
    //     {
    //         System.Console.WriteLine(item);
    //     }
    // }

    //Shallow copy
    int[] arr = [.. Enumerable.Range(1, 5)];
    int[] b = (int[])arr.Clone();

    arr.CopyTo(b, 0);

    //deep copy
    Person[] copy =
    [
        new Person
    {
        Name = person.Name
    }
    ];



    foreach (var i in arr)
        Console.WriteLine(i);

    System.Console.WriteLine(s.Item1, s.Item2);

    //Anonymous Types, Nested Anonymous types
    var klol = new
    {
        Id = 1,
        Name = "Myra"
    };
    // Anonymous types:

    // are reference types
    // are immutable (readonly properties)
    // use var
    // compiler-generated

    //Nested 
    var employee = new
    {
        Id = 1,
        Name = "Myra",

        Address = new
        {
            City = "Delhi",
            Country = "India"
        }
    };

    Console.WriteLine(employee.Address.City);
}

static void NewMethod4()
{

    //Tuples 
    Tuple<int, string> t = new(4, "st");
    (int a, int b) = (7, 8);
    System.Console.WriteLine(a);

    var person = (1, "Myra");
    var (id, name) = person;

    (a, b) = (b, a); // swapped

    var data = (1, ("Delhi", "India")); // nested tuples
    var (ids, (city, country)) = data;
    Console.WriteLine(city);

    //LinQ Language intergrated queries
    IEnumerable<Person> lp = [
     new(){Id=1,Name="test"},
 new(){Id=2,Name="te"},
 new(){Id=3,Name="t"},
 new(){Id=4,Name="st"},
];
    // where select first firstofdefault singleofdefault 
    //Find, FindAt,Remove,RemoveAt,OrderBy,desc,Single,Any
    //All,count,sum,min/max, avg,Aggregate
    // IEnumerable
    // IEnumerable<T>

    var res = from num in lp where num.Id == 70 select num;
    lp.Average(x => x.Id);
    Person j = lp.Aggregate((x, y) => new() { Id = x.Id + y.Id, Name = x.Name + "," + y.Name });
    System.Console.WriteLine(j.Id + " " + j.Name);

    //2. Module Initializers (C# 9)

    //Runs automatically before any code in assembly executes.


    Person1 p = new()
    {
        Address = new Address
        {
            City = "Delhi"
        }
    };

    string result = p switch
    {
        { Address.City: "Delhi" } => "Matched",
        { Address: { City: "Delhis" } } => "Mathced",
        _ => "No"
    };
}

static void DelegatesAndEvents()
{
    // using FileManager fm = new();
    // Console.WriteLine("Using resource");
    MyDelegate myDelegate = DelegatesExample.Method;
    myDelegate += DelegatesExample.Method1;
    myDelegate.Invoke("first message");

    MyDelegate1<object> myDelegate1 = DelegatesExample.Method3;
    myDelegate1("1", "first", 9, 0.8);


    //Raw string literals allow multi-line strings without escaping characters.
    string dis = """
This is first sring 
  sktells
""";
    System.Console.WriteLine(dis);

    //List patterns match arrays or collections by structure.
    int[] numbers = [1, 2, 3];

    if (numbers is [1, 2, 3])
    {
        Console.WriteLine("Matched!");
    }
    if (numbers is [1, _, 3])
    {
        Console.WriteLine("Middle value ignored");
    }

    //Slice pattern (..) matches remaining elements in a collection.
    int[] nums = [1, 2, 3, 4, 5];

    if (nums is [1, .., 5])
    {
        Console.WriteLine("Starts with 1 and ends with 5");
    }


    if (nums is [1, .. var middle, 5])
    {
        Console.WriteLine(string.Join(",", middle));
    }
}



static void ThreadingMethod()
{
    //1. Thread Class
    //A Thread represents an independent path of execution in a program.

    Threads threads = new();
    Thread thread = new(threads.Print);
    Thread thread1 = new(threads.Print1);
    //  Console.WriteLine(thread.ThreadState);
    // thread.Start();
    //  Console.WriteLine(thread.ThreadState);
    // thread.Join(); 
    //  Console.WriteLine(thread1.ThreadState);
    // thread1.Start();
    //  Console.WriteLine(thread1.ThreadState);
    // Thread.Join()
    // Makes one thread wait until another thread finishes.

    // 5. Thread Priority
    // Controls execution priority.
    // Lowest
    // BelowNormal
    // Normal
    // AboveNormal
    // Highest


    // 6. Thread States

    // Common states:

    // Unstarted
    // Running
    // WaitSleepJoin
    // Stopped
    // Suspended (obsolete)

    // 7. Thread with Parameters
    // ParameterizedThreadStart
    Threads t = new();
    Thread te = new(t.Print2);

    //te.Start("Myra");

    // 8. Callback Method in Threading

    // A callback method executes after another operation completes.
    Threads pr = new();
    Callback callback = new(pr.Completed);
    Thread pro = new(() => pr.Process(callback));

    //pro.Start();


    // 9. Monitor

    // Monitor provides synchronization to avoid multiple threads accessing shared resources simultaneously.
    // Methods:
    // Enter()
    // Exit()

    // 10. lock Keyword
    // Simplified version of Monitor.


    Threads obj = new();
    Thread thread3 = new(obj.LockObjExample)
    {
        Name = "Thread First",
        Priority = ThreadPriority.BelowNormal
    };
    //thread3.Start(thread3.Name);

    Thread thread4 = new(obj.LockObjExample)
    {
        Name = "Thread Second",
        Priority = ThreadPriority.AboveNormal
    };
    //thread4.Start(thread4.Name);

    //thread3.Join();
    //thread4.Join();


    // 11. ManualResetEvent
    // Signals multiple threads until manually reset.
    ManualResetEvent mre = new ManualResetEvent(false);
    AutoResetEvent are = new AutoResetEvent(false);
    void Worker(object name)
    {
        Console.WriteLine(name + " Waiting...");
        are.WaitOne();
        Console.WriteLine(name + " Thread Released");
    }
    Thread t1 = new Thread(Worker);
    Thread t2 = new Thread(Worker);

    // t1.Start("one");
    // t2.Start("TWO");

    //Thread.Sleep(2000);

    // are.Set();
    // are.Set();

    // 16. Semaphore
    // Allows limited number of threads to access resource.

    Thread thread5 = new(obj.WorkerCountdown)
    {
        Name = "fifth Second",
        Priority = ThreadPriority.AboveNormal
    };
    Thread thread6 = new(obj.WorkerCountdown)
    {
        Name = "six Second",
        Priority = ThreadPriority.AboveNormal
    };
    Thread thread7 = new(obj.WorkerCountdown)
    {
        Name = "seven Second",
        Priority = ThreadPriority.AboveNormal
    };
    // thread5.Start();
    // thread6.Start();
    // thread7.Start();

    //Threads.countdown.Wait();

    // 18. Thread Pool
    // Reuses threads to improve performance.

    // 19. CountdownEvent
    // Waits until signal count becomes zero.


    //20.Producer and consumer
    Thread producer = new Thread(ProducerConsumer.Producer);
    Thread consumer = new Thread(ProducerConsumer.Consumer);
    Thread inventary = new Thread(ProducerConsumer.CurrentItem);
    producer.Start();
    consumer.Start();
    inventary.Start();
}

static async Task<(Task<int> task1, Task<int> task2, CancellationTokenSource cts)> TaskLibrary()
{
    // C# Tasks (TPL - Task Parallel Library)

    // Task is a modern way to perform asynchronous and parallel programming in C#.

    // | Drawback                 | Explanation                           |
    // | ------------------------ | ------------------------------------- |
    // | Heavyweight              | Creating threads consumes memory      |
    // | Slow creation            | Thread creation is expensive          |
    // | Manual management        | Need to start, stop, synchronize      |
    // | Complex code             | Difficult to maintain                 |
    // | Poor scalability         | Too many threads reduce performance   |
    // | No built-in return value | Threads don't directly return results |


    // Why Tasks?

    // Task solves these issues by:

    // Using ThreadPool internally
    // Better performance
    // Easier async programming
    // Supports return values
    // Built-in cancellation and continuation

    // Task t = new(TaskLib.Work);
    // t.Start();
    // t.Wait();
    //or Simplest way to create and start task.
    Stopwatch sw = new Stopwatch();
    sw.Start();
    Task<int> task1 = Task.Run(() => TaskLib.Add());
    Task<int> task2 = Task.Run(() => TaskLib.Add());
    //test.Wait(); //Waits for task completion.
    //Task.WaitAll(task1,task2);  //Waits for multiple tasks.
    sw.Stop();
    // 8. Task.Delay() Non-blocking delay.
    Task t = Task.Delay(2000);
    // Non-blocking delay.


    // 9. Task.ContinueWith()
    // Runs another task after completion.
    //try
    //{
    //    Task y = Task.Run(() =>
    //    {
    //        Console.WriteLine("First Task");
    //    });

    //    await t.ContinueWith(x =>
    //    {
    //        Console.WriteLine("Second Task");
    //    });
    //}
    //catch (AggregateException ex)
    //{
    //    Console.WriteLine(ex.InnerException.Message);
    //}

    // 10. Task Exception Handling

    // Exceptions inside tasks should be handled using:

    // try-catch
    // AggregateException

    // 11. Continuation Chain
    // Multiple tasks connected sequentially.
    //await Task.Run(() =>
    //{
    //    Console.WriteLine("Step 1");
    //    return "Data from 1";
    //})
    //.ContinueWith(t =>
    //{
    //    string result1 = t.Result; // Retrieves string from Step 1
    //    Console.WriteLine($"Step 2 received: {result1}");
    //    return "Data from 2";
    //})
    //.ContinueWith(t =>
    //{
    //    string result2 = t.Result; // Retrieves string from Step 2
    //    Console.WriteLine($"Step 3 received: {result2}");
    //    return "Final Data";
    //});

    // 12. Task Cancellation
    // Uses CancellationTokenSource.
    //Task cancellation allows us to stop a running task gracefully.
    // Instead, cancellation works using a cooperative mechanism.

    // That means:

    // Main thread sends cancellation request
    // Task checks for cancellation
    // Task stops itself safely

    // | Class                                  | Purpose                               |
    // | -------------------------------------- | ------------------------------------- |
    // | `CancellationTokenSource`              | Sends cancellation request            |
    // | `CancellationToken`                    | Receives cancellation signal          |
    // | `token.IsCancellationRequested`        | Checks whether cancellation requested |
    // | `token.ThrowIfCancellationRequested()` | Throws cancellation exception         |

    // CancellationTokenSource
    //             ↓
    //      Generates Token
    //             ↓
    // Token passed to Task
    //             ↓
    // Task checks token status
    //             ↓
    // If cancelled → stop execution

    CancellationTokenSource cts = new();
    CancellationToken token = cts.Token;
    // Start task
    Task canceltask = Task.Run(() =>
    {
        for (int i = 1; i <= 10; i++)
        {
            //token.ThrowIfCancellationRequested();
            //or 
            // Check cancellation request
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation Requested");

                // return;
            }

            Console.WriteLine("Processing: " + i);

            Thread.Sleep(500);
        }

    }, token);

    // Wait 3 seconds
    Thread.Sleep(500);

    // Cancel task
    cts.Cancel();

    t.Wait();

    Console.WriteLine("Main Completed");
    Console.WriteLine(sw.ElapsedMilliseconds);
    return (task1, task2, cts);
}

static void MultiThreadingWithCancel()
{
    //Example with mutiple tasks
    // A single CancellationTokenSource can cancel multiple tasks together.
    // All tasks share the same CancellationToken. 

    // CancellationTokenSource
    //             ↓
    //       Shared Token
    //       ↓     ↓     ↓
    //     Task1 Task2 Task3
    //             ↓
    //        cts.Cancel()
    //             ↓
    //  All Tasks Receive Cancellation

    CancellationTokenSource cancelTokenSource =
               new CancellationTokenSource();
    CancellationToken token1 = cancelTokenSource.Token;
    Task t1 = Task.Run(() => { TaskLib.DoWork("first", token1); }, token1);

    Task t2 = Task.Run(() => { TaskLib.DoWork("sencond", token1); }, token1);

    Task t3 = Task.Run(() => { TaskLib.DoWork("third", token1); }, token1);
    Thread.Sleep(2000);

    // Cancel all tasks
    Console.WriteLine("Cancelling Tasks...");

    cancelTokenSource.Cancel();

    // Wait for all tasks
    Task.WaitAll(t1, t2, t3);

    Console.WriteLine("Main Completed");
}