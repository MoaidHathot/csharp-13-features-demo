public class Demo_04_field_keyword_02
{
 
}

public class FullPropertiesModification
{
	private int _foo;

	public int Foo 
	{
		get => _foo;
		set 
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(value), "Value must be greater than or equal to 0.");
			}

			_foo = value;
		}
	}
}

