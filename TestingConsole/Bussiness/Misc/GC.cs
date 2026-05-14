public class Table
{
    public int T=90;
    public Table()
    {
        System.Console.WriteLine("constructorDemo called");
        T=200;
    }
    ~Table()
    {
        System.Console.WriteLine("DISTRUCTOR CALLED ");
    }
}

class FileManager : IDisposable
{
    private bool disposed = false;

    public FileManager()
    {
        Console.WriteLine("Resource Acquired");
    }

    // Public Dispose Method
    public void Dispose()
    {
        Dispose(true);

        // Prevent destructor from running
        GC.SuppressFinalize(this);
    }

    // Core Cleanup Logic
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Cleanup managed resources
                Console.WriteLine("Managed resources cleaned");
            }

            // Cleanup unmanaged resources
            Console.WriteLine("Unmanaged resources cleaned");

            disposed = true;
        }
    }

    // Destructor / Finalizer
    ~FileManager()
    {
        Console.WriteLine("Destructor called");

        Dispose(false);
    }
}