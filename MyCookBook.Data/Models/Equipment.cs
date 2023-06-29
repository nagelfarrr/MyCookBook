using System.ComponentModel.DataAnnotations;

using static MyCookBook.Common.DataModels.EquipmentValidationConstants;

namespace MyCookBook.Data.Models
{
	public class Equipment
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		public string Name { get; set; } = null!;

	}
}
