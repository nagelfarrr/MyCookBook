using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCookBook.Data.Models;

using Newtonsoft.Json;

namespace MyCookBook.Data
{
	public class MyCookBookDbContext : IdentityDbContext
	{
		

		public MyCookBookDbContext(DbContextOptions<MyCookBookDbContext> options)
			: base(options)
		{
		}

		private List<Ingridient> IngridientsImport { get; set; }

		public DbSet<Equipment> Equipments { get; set; } = null!;
		public DbSet<EquipmentRequirement> EquipmentRequirements { get; set; } = null!;
		public DbSet<Ingridient> Ingridients { get; set; } = null!;
		public DbSet<Instruction> Instructions { get; set; } = null!;
		public DbSet<Recipe> Recipes { get; set; } = null!;
		public DbSet<RecipeComment> RecipeComments { get; set; } = null!;
		public DbSet<RecipeIngredient> RecipesIngridients { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder
				.Entity<RecipeComment>()
				.HasOne(c => c.Recipe)
				.WithMany(r => r.Comments)
				.OnDelete(DeleteBehavior.NoAction);

			builder
				.Entity<RecipeComment>()
				.HasOne(c => c.User)
				.WithMany(u => u.Comments)
				.OnDelete(DeleteBehavior.NoAction);

			SeedIngridients();
			builder
				.Entity<Ingridient>()
				.HasData(IngridientsImport);

			base.OnModelCreating(builder);
		}


		private void SeedIngridients()
		{
			string inputJsonIngridients = File.ReadAllText(@"..\MyCookBook.Data\Datasets\IngridientsData.json");

			IngridientsImport = JsonConvert.DeserializeObject<List<Ingridient>>(inputJsonIngridients);

		}

	}

}