using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CustomizedTestStackDossierExample
{
	public class Customer
	{
		public int Id;

		[StringLength(100)]
		public string FirstName { get; set; }

		[StringLength(100)]
		public string LastName { get; set; }

		public int Age { get; set; }

		public Address Address { get; set; }
		public List<Order> Orders { get; set; }
	}
}
