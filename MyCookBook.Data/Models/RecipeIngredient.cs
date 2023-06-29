using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyCookBook.Common.DataModels.RecipeIngridientValidationConstants;

namespace MyCookBook.Data.Models
{
	public class RecipeIngredient
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(UnitMaxLength)]
		public string Unit { get; set; } = null!;

		[Required]
		[Range(AmountMinLength, AmountMaxLength)]
		public double Amount { get; set; }

		[Required]
		[ForeignKey(nameof(Recipe))]
		public int RecipeId { get; set; }
		public Recipe Recipe { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Ingridient))]
		public int IngridientId { get; set; }
		public Ingridient Ingridient { get; set; } = null!;
	}
}
