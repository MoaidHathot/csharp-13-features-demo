public class Demo_02_implicit_indexer_02 : IDemo
{
    public void Run()
    {
        var countable = new MyObject();

        countable[0] = 1;
    }
}

public class MyObject
{
    private readonly int[] _values = new int[4];

    public int this[int index]
    {
        get => _values[index];
        set => _values[index] = value;
    }
}


