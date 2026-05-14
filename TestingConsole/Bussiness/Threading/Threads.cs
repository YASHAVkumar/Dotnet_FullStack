public delegate void Callback(int sum);

public class Threads
{
     static Object obj=new();
    public static int Counter=0;
//     16. Semaphore
// Allows limited number of threads to access resource.
    static Semaphore sem = new(1, 2);
//     17. Mutex
// Used for synchronization between processes.
    static Mutex mutex = new Mutex();

// 19. CountdownEvent
// Waits until signal count becomes zero.
   public static CountdownEvent countdown = new(3);
    public void Print()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine("i:"+i);
              System.Threading.Thread.Sleep(100); // Prevents 100% CPU lock while testing
        }
    }
     public void Print1()
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine("i1 :"+i);
              System.Threading.Thread.Sleep(100); // Prevents 100% CPU lock while testing
        }
    }
      public void Print2(object name)
    {
        for (int i = 0; i < 100; i++)
        {
            System.Console.WriteLine($"Hi {name}  :{i}");
              System.Threading.Thread.Sleep(100); // Prevents 100% CPU lock while testing
        }
    }

    public void Process(Callback callback)
    {int sum=0;
        System.Console.WriteLine("Processing .....");
          for (int i = 0; i < 100; i++)
          {
            sum+=i;
          }
          Thread.Sleep(100);
          callback(sum);
    }
    public void Completed(int sum)
    {
         System.Console.WriteLine("Completed callback");
         System.Console.WriteLine("Sum=: "+sum);
    }


    public void MonitorExample(object threadName)
    {
        Monitor.Enter(obj);
        try
        {
            Counter++;
            System.Console.WriteLine("Thread Locked by "+threadName);
        }
        finally
        {
            Monitor.Exit(obj);
        }
    }
    public void LockObjExample(object threadName)
    {
        
        lock(obj)
        {
            Counter++;
            System.Console.WriteLine("Thread Locked by "+threadName);
        }
    }

    public void Workers()
    {
        sem.WaitOne();

        Console.WriteLine(Thread.CurrentThread.Name + " entered");

        Thread.Sleep(2000);

        Console.WriteLine(Thread.CurrentThread.Name + " leaving");

        sem.Release();
    }
    public void WorkerMutex()
    {
        mutex.WaitOne();

        Console.WriteLine(Thread.CurrentThread.Name + " entered");

        Thread.Sleep(2000);

        Console.WriteLine(Thread.CurrentThread.Name + " leaving");

        mutex.ReleaseMutex();
    }
  public void WorkerCountdown()
    {
        Console.WriteLine(Thread.CurrentThread.Name + " entered");
        Counter++;
        Thread.Sleep(2000);

        Console.WriteLine(Thread.CurrentThread.Name + " leaving");
         countdown.Signal();
    }
}