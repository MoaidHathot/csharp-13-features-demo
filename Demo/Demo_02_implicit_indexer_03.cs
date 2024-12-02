public class Demo_02_implicit_indexer_03 : IDemo
{
    public void Run()
    {
        var countable = new CountableObject();

        countable[0] = 1;
		countable[^1] = 4;
		countable[new Index(2, fromEnd: true)] = 3;
    }
}

public class CountableObject
{
    private readonly int[] _values = new int[4];
	public int Length => _values.Length;

    public int this[int index]
    {
        get => _values[index];
        set => _values[index] = value;
    }
}



