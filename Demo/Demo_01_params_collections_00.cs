public class Demo_01_params_collections_00 : IDemo
{
	void Run()
	{
		Foo(1, 2, 3, 4);
	}

	void Foo(params int[] values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}
