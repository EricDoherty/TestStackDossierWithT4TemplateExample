using System.ComponentModel.DataAnnotations;

namespace CustomizedTestStackDossierExample
{
	public class Item
	{
		public int Id;

		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(100)]
		public string BrandName { get; set; }

		public double Cost { get; set; }

		public int OrderId { get; set; }

		public Order Order { get; set; }
	}
}
