public class Demo_01_params_collections_06 : IDemo
{
	public void Run()
	{
		Foo(1, 2, 3, 4);
		NoAddCollection noAddCollection = [1, 2, 3, 4, 5, 6];
	}

	void Foo(params NoAddCollection values)
	{
		foreach (var value in values)
		{
			value.Dump();
		}
	}
}

[CollectionBuilder(typeof(NoAddCollectionBuilder), "Create")]
public class NoAddCollection : IEnumerable<int>
{
	private readonly IEnumerable<int> _values;

	public NoAddCollection()
	{
		_values = [];
	}

	public NoAddCollection(IEnumerable<int> values)
	{
		_values = values;
	}

    public IEnumerator<int> GetEnumerator()
		=> _values.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator()
		=> GetEnumerator();
}

public class NoAddCollectionBuilder
{
	public static NoAddCollection Create(ReadOnlySpan<int> values)
	{
		return new NoAddCollection(values.ToArray());
	}
}

