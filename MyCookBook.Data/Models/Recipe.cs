using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyCookBook.Common.DataModels.RecipeValidationConstants;

namespace MyCookBook.Data.Models
{
	public class Recipe
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(TitleMaxLength)]
		public string Title { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Required]
		[MaxLength(ImageFileMaxLength)]
		public string ImageFile { get; set; } = null!;

		[Required]
		public DateTime DatePosted { get; set; }

		[Required]
		[ForeignKey(nameof(Author))]
		public string AuthorId { get; set; } = null!;
		public CookBookUser Author { get; set; } = null!;

		public List<EquipmentRequirement> EquipmentRequirements { get; set; } = new List<EquipmentRequirement>();
		public List<RecipeIngredient> RecipesIngridients { get; set; } = new List<RecipeIngredient>();
		public List<Instruction> Instructions { get; set; } = new List<Instruction>();
		public List<RecipeComment> Comments { get; set; } = new List<RecipeComment>();


	}
}
