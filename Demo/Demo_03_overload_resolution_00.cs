public class Demo_03_overload_resolution_00 : IDemo
{
	public void Run()
	{
		OverloadResolution(1, 2, 3);
	}

	void OverloadResolution(params int[] arr)
	{
		"Params Array".Dump();
	}

	// [OverloadResolutionPriority(1)]
	void OverloadResolution(params IEnumerable<int> arr)
	{
		"Params Enumerable".Dump();
	}

	// void OverloadResolution(params ReadOnlySpan<int> arr)
	// {
	// 	"Params ReadOnlySpan".Dump();
	// }
}
