using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
	public class Catalog
	{
		public int Id { get; set; }
		public string? Item { get; set; }
		public string? ItemType { get; set; }
		public string? Material { get; set; }
		[DataType(DataType.Date)]
		public DateTime DateCreated { get; set; }
		public decimal Price { get; set; }
	}
}
