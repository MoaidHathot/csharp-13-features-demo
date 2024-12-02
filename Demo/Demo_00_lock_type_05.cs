public class Demo_00_lock_type_05 : IDemo
{
    public void Run()
    {
        var _lock = new Lock();

        // lock (_lock)
        // {
        //     "Critical Section".Dump();
        // }

        Lock.Scope scope = _lock.EnterScope();

        try
        {
            "Critical Section".Dump();
        }
        finally
        {
            scope.Dispose();
        }
    }
}

