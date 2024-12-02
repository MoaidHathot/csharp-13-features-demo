public class Demo_04_field_keyword_03
{
	public void Run()
	{
	}
}

public class PropertiesWithFieldKeyword
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
