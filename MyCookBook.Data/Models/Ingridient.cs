using System.ComponentModel.DataAnnotations;

using static MyCookBook.Common.DataModels.IngridientValidationConstants;

namespace MyCookBook.Data.Models
{
	public class Ingridient
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength, ErrorMessage = NameMaxLengthErrorMessage)]
		public string Name { get; set; } = null!;

		[Required]
		[MaxLength(DescriptionMaxLength, ErrorMessage = DescriptionMaxLengthErrorMessage)]
		public string Description { get; set; } = null!;

	}
}
