using System;

using R5T.T0132;


namespace R5T.T0140.Z001
{
	[FunctionalityMarker]
	public partial interface ITypeOperations : IFunctionalityMarker
	{
		public Type GetPartiallyConstructedType()
		{
			var openGenericTypeArgument = Instances.TypeOperator.Get_GenericTypeParameters_OfType(typeof(ExampleClass02<,>))[1];

			var partiallyConstructedType = typeof(ExampleClass02<,>)
				.MakeGenericType(
					typeof(ExampleClass00),
					openGenericTypeArgument);

			return partiallyConstructedType;
		}
	}
}