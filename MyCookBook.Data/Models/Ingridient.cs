using System.ComponentModel.DataAnnotations;

using static MyCookBook.Common.DataModels.IngridientValidationConstants;

namespace MyCookBook.Data.Models
{
	public class Ingridient
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;
	}
}
