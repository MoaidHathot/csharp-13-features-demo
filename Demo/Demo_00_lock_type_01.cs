public class Demo_00_lock_type_01 : IDemo
{
    public void Run()
    {
		var _lock = new Lock();

		lock (_lock)
		{
			"Critical Section".Dump();
		}
    }
}

