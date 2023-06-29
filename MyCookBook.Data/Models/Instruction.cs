using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static MyCookBook.Common.DataModels.InstructionValidationConstants;

namespace MyCookBook.Data.Models
{
	public class Instruction
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(StepMinLength, StepMaxLength)]
        public int Step { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;
    }
}
