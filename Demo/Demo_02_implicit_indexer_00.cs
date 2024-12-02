public class Demo_02_implicit_indexer_00 : IDemo
{
	public void Run()
	{
		new ImplicitIndexer
		{
			[0] = 1,
			[1] = 2,
			[2] = 3,
			[3] = 4
		}.Dump(members: new MembersConfig { IncludeFields = true, IncludeNonPublicMembers = true });
	}
}

public class ImplicitIndexer
{
	private readonly int[] _values = new int[4];

	public int this[int index]
	{
		get => _values[index];
		set => _values[index] = value;
	}
}
