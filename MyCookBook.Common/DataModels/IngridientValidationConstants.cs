namespace MyCookBook.Common.DataModels
{
	public static class IngridientValidationConstants
	{
		public const int NameMinLength = 3;
		public const int NameMaxLength = 20;
		public const string NameMinLengthErrorMessage = "Name should be atleast 3 characters long.";
		public const string NameMaxLengthErrorMessage = "Name cannot be more than 20 characters long.";

		public const int DescriptionMinLength = 20;
		public const int DescriptionMaxLength = 150;
		public const string DescriptionMinLengthErrorMessage = "Description should be atleast 20 characters long.";
		public const string DescriptionMaxLengthErrorMessage = "Description cannot be more than 150 characters.";
	}
}
