
public class Demo_01_params_collections_05 : IDemo
{
	public void Run()
	{
		Foo(1, 2, 3, 4);

		var collection = new MyCollection
		{
			5,
			6,
			7,
			8
		};
	}

	void Foo(params SupportObjectInitializer values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}

public class SupportObjectInitializer : IEnumerable<int>
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

