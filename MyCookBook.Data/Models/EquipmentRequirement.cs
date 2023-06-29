using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCookBook.Data.Models
{
	public class EquipmentRequirement
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[ForeignKey(nameof(Recipe))]
		public int RecipeId { get; set; }
		public Recipe Recipe { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Equipment))]
		public int EquipmentId { get; set; }
		public Equipment Equipment { get; set; } = null!;
	}
}
