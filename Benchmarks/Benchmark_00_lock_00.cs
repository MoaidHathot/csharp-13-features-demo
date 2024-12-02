// [HideColumns("Job", "Error", "StdDev", "Median", "RatioSD")]
public class Benchmark_00_lock_00
{
    private int _value1;
    private int _value2;

	private readonly object _monitor = new();
	private readonly Lock _lock = new();

    [Benchmark]
    public void WithMonitor()
    {
        lock (this)
        {
            _value1++;
        }
    }

    [Benchmark]
    public void WithLock()
    {
        lock (_lock)
        {
            _value2++;
        }
    }
}

