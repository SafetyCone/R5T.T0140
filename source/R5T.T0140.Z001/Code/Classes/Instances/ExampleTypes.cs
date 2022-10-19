using System;


namespace R5T.T0140.Z001
{
	public class ExampleTypes : IExampleTypes
	{
		#region Infrastructure

	    public static IExampleTypes Instance { get; } = new ExampleTypes();

	    private ExampleTypes()
	    {
        }

	    #endregion
	}
}