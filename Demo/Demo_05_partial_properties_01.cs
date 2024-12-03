public class Demo_05_partial_properties_01
{
 
}

public partial class PartialClassB
{
	partial void Foo();
	partial string Bar { get; set; }
}

public partial class PartialClassB
{
	
	partial void Foo()
	{
	}

	partial string Bar 
	{
		get => "Bar";
		set => throw new NotImplementedException(); 
	}
}
