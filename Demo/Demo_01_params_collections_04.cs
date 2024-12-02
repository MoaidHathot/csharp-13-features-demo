
public class Demo_01_params_collections_04 : IDemo
{
	public void Run()
	{
		Foo(1, 2, 3, 4);
		MyCollection noAddCollection = [1, 2, 3, 4, 5, 6];
	}

	void Foo(params MyCollection values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}

public class MyCollection : IEnumerable<int>
{
	private readonly List<int> _values = [];

    public IEnumerator<int> GetEnumerator()
		=> _values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
		=> GetEnumerator();

	public void Add(int value)
	{
		_values.Add(value);
	}
}
