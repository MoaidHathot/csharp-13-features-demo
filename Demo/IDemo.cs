public interface IDemo
{
	void Run()
	{

	}

	Task RunAsync()
	{
		return Task.CompletedTask;
	}
}
