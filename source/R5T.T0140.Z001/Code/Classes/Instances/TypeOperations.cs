using System;


namespace R5T.T0140.Z001
{
	public class TypeOperations : ITypeOperations
	{
		#region Infrastructure

	    public static ITypeOperations Instance { get; } = new TypeOperations();

	    private TypeOperations()
	    {
        }

	    #endregion
	}
}