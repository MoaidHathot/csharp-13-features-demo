public class Demo_00_lock_type_02 : IDemo
{
    public void Run()
    {
        var _lock = new object();

        // lock (_lock)
        // {
        //     "Critical Section".Dump();
        // }

        bool lockWasTaken = false;
        try
        {
            Monitor.Enter(_lock, ref lockWasTaken);
        }
        finally
        {
            if (lockWasTaken)
            {
                Monitor.Exit(_lock);
            }
        }
    }
}
