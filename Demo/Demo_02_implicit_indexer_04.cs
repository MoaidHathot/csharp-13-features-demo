public class Demo_02_implicit_indexer_04 : IDemo
{
    public void Run()
    {
        var countable = new CountableWithRange();

        countable[0] = 1;
		countable[^1] = 4;
		countable[new Index(2, fromEnd: true)] = 3;
		countable[..2].Dump();
		countable[new Range(0, 2)].Dump();
    }
}

public class CountableWithRange
{
    private readonly int[] _values = new int[4];
	public int Length => _values.Length;

    public int this[int index]
    {
        get => _values[index];
        set => _values[index] = value;
    }

	public IEnumerable<int> Slice(int start, int end)
	{
		return _values[start..end];
	}
}




