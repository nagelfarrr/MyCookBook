using Microsoft.AspNetCore.Identity;

namespace MyCookBook.Data.Models
{
	public class CookBookUser : IdentityUser
	{
		public List<Recipe> Recipes { get; set; } = new List<Recipe>();
		public List<RecipeComment> Comments { get; set; } = new List<RecipeComment>();

	}
}
