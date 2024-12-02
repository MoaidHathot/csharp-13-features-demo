public class Demo_03_overload_resolution_02 : IDemo
{
	public void Run()
	{
		OverloadResolution(1, 2, 3);
	}

	void OverloadResolution(params int[] arr)
	{
		"Params Array".Dump();
	}

	[OverloadResolutionPriority(1)]
	void OverloadResolution(params IEnumerable<int> arr)
	{
		"Params Enumerable".Dump();
	}

	[OverloadResolutionPriority(-1)]
	void OverloadResolution(params ReadOnlySpan<int> arr)
	{
		"Params ReadOnlySpan".Dump();
	}
}
