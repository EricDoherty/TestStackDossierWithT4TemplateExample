using System.Collections.Generic;

namespace CustomizedTestStackDossierExample
{
	public class Order
	{
		public int Id;

		public int CustomerId { get; set; }

		public Customer Customer { get; set; }

		public List<Item> Items { get; set; }
	}
}
