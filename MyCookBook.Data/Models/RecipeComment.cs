using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyCookBook.Common.DataModels.RecipeCommentValidationConstants;

namespace MyCookBook.Data.Models
{
	public class RecipeComment
	{
        [Key]
        public int Id { get; set; }

        [MaxLength(CommentMaxLength)]
        public string? Comment { get; set; }

        [Required]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public CookBookUser User { get; set; } = null!;
    }
}
