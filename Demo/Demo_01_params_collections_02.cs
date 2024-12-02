public class Demo_01_params_collections_02 : IDemo
{
	public void Run()
	{
		Foo(1, 2, 3, 4);
	}

	void Foo(params Span<int> values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}


