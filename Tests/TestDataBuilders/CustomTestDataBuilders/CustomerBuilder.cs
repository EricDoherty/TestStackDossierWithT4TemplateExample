using CustomizedTestStackDossierExample;
using TestStack.Dossier;

public partial class CustomerBuilder : TestDataBuilder<Customer, CustomerBuilder>
{
	protected override CustomerBuilder PopulateDefaultValues()
	{
		WithAge(20);

		return base.PopulateDefaultValues();
	}
}

