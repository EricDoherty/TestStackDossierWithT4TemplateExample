using System;
using TestStack.Dossier;

namespace Tests.TestHelpers
{
	public class IdValueSupplier : IAnonymousValueSupplier
	{

		public IdValueSupplier()
		{
		}

		public bool CanSupplyValue(Type type, string propertyName)
		{
			return propertyName.ToLower().EndsWith("id") && type == typeof(int);
		}

		public object GenerateAnonymousValue(AnonymousValueFixture any, Type type, string propertyName)
		{
			return 0;
		}

	}

	public class NullableIdValueSupplier : IAnonymousValueSupplier
	{

		public NullableIdValueSupplier()
		{
		}

		public bool CanSupplyValue(Type type, string propertyName)
		{
			return propertyName.ToLower().EndsWith("id") && type == typeof(Nullable<int>);
		}

		public object GenerateAnonymousValue(AnonymousValueFixture any, Type type, string propertyName)
		{
			return null;
		}

	}
}
