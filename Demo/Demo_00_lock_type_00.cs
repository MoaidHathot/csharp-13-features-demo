public class Demo_00_lock_type_00 : IDemo
{
    public void Run()
    {
		var _lock = new object();

		lock (_lock)
		{
			"Critical Section".Dump();
		}
    }
}
