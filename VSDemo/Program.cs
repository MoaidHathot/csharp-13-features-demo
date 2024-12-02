Console.WriteLine("Field Keyword");

public class FullPropertiesModification
{
	public int Foo 
	{
		get => field;
		set 
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(value), "Value must be greater than or equal to 0.");
			}

			field = value;
		}
	}
}
