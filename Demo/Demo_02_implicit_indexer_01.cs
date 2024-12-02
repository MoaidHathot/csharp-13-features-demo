public class Demo_02_implicit_indexer_01 : IDemo
{
	public void Run()
	{
		new ImplicitIndexerReverse
		{
			[^1] = 1,
			[^2] = 2,
			[^3] = 3,
			[^4] = 4
		}.Dump(members: new MembersConfig { IncludeFields = true, IncludeNonPublicMembers = true });
	}
}

public class ImplicitIndexerReverse
{
	private readonly int[] _values = new int[4];
	public int Length => _values.Length;

	public int this[int index]
	{
		get => _values[index];
		set => _values[index] = value;
	}
}

