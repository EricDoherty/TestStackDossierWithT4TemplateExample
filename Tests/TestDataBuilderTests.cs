using System.Linq;
using CustomizedTestStackDossierExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.Dossier.Lists;
using TestStack.Dossier;
using Tests.TestHelpers;

namespace Tests
{
	[TestClass]
	public class TestDataBuilderTests
	{
		[TestMethod]
		public void CreateCustomerWithTestDataBuilder()
		{
			AnonymousValueFixture.GlobalValueSuppliers.Add(new IdValueSupplier());

			Customer customer = new CustomerBuilder()
				.WithFirstName("Bob")
				.WithLastName("Johnson")
				.WithAddress((address) => address.WithCity("Olympia")
												 .WithZipCode("98502"))
				.WithOrders(1, (orders) => orders.All()
					.WithItems(2, (items) => items.TheFirst(1).WithName("Donut")
												  .TheNext(1).WithName("Pancake")));

			Assert.AreEqual(0, customer.Id); // The Id should be 0 because of the Anonymous value supplier IdValueSupplier
			Assert.AreEqual(20, customer.Age); // The Age is set to 20 by the partial class CustomerBuilder in the CustomTestDataBuilders folder
			Assert.AreEqual("Bob", customer.FirstName);
			Assert.AreEqual("Johnson", customer.LastName);
			Assert.AreEqual("Olympia", customer.Address.City);
			Assert.AreEqual("98502", customer.Address.ZipCode);
			Assert.AreEqual("Donut", customer.Orders.First().Items[0].Name);
			Assert.AreEqual("Pancake", customer.Orders.First().Items[1].Name);
		}
	}
}
