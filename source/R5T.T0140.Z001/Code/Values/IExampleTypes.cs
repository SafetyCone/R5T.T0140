using System;

using R5T.T0131;


namespace R5T.T0140.Z001
{
	[ValuesMarker]
	public partial interface IExampleTypes : IValuesMarker
	{
		/// <summary>
		/// <inheritdoc cref="Y0000.Glossary.ForType.ClosedGeneric" path="/definition"/>
		/// </summary>
		public Type ClosedGeneric_SingleTypeParameter => typeof(ExampleClass01<ExampleClass00>);

		/// <summary>
		/// <inheritdoc cref="Y0000.Glossary.ForType.ClosedGeneric" path="/definition"/>
		/// </summary>
		public Type ClosedGeneric_DoubleTypeParameter => typeof(ExampleClass02<string, int>);

		/// <summary>
		/// Chooses <see cref="ClosedGeneric_SingleTypeParameter"/> as the default.
		/// </summary>
		public Type ClosedGeneric => this.ClosedGeneric_SingleTypeParameter;

		/// <summary>
		/// <inheritdoc cref="Y0000.Glossary.ForType.OpenGeneric" path="/definition"/>
		/// </summary>
		public Type OpenGenericClass_SingleTypeParameter => typeof(ExampleClass01<>);

		/// <summary>
		/// Chooses <see cref="OpenGenericClass_SingleTypeParameter"/> as the default.
		/// </summary>
		public Type OpenGenericClass => this.OpenGenericClass_SingleTypeParameter;

		/// <summary>
		/// <inheritdoc cref="Y0000.Glossary.ForType.OpenGeneric" path="/definition"/>
		/// </summary>
		public Type OpenGenericClass_DoubleTypeParameter => typeof(ExampleClass02<,>);

		/// <summary>
		/// <inheritdoc cref="Y0000.Glossary.ForType.PartiallyConstructedGeneric" path="/definition"/>
		/// </summary>
		public Type PartiallyConstructedType => Instances.TypeOperations.GetPartiallyConstructedType();

		public Type NonGeneric => typeof(String);

		public Type BasicClass => this.BasicClass_NonSystem;

		/// <summary>
		/// A basic class not from the <see cref="System"/> namespace.
		/// </summary>
		public Type BasicClass_NonSystem => typeof(ExampleClass00);

		/// <summary>
		/// A class type from the <see cref="System"/> namespace.
		/// </summary>
        public Type BasicClass_System => typeof(String);
    }
}