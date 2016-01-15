using System.ComponentModel.DataAnnotations;

namespace CustomizedTestStackDossierExample
{
	public class Item
	{
		public int Id;

		[StringLength(50)]
		public string Name;

		public double Cost;
	}
}
