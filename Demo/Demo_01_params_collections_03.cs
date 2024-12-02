public class Demo_01_params_collections_03 : IDemo
{
	public void Run()
	{
		Foo(1, 2, 3, 4);
	}

	void Foo(params ReadOnlySpan<int> values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}



