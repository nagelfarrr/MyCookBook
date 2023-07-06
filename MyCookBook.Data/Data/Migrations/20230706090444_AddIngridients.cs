using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCookBook.Data.Migrations
{
    public partial class AddIngridients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingridients",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ingridients",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Ingridients",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "A mineral substance used for seasoning and preserving food.", "Salt" },
                    { 2, "A sweet crystalline substance used as a sweetener and flavor enhancer.", "Sugar" },
                    { 3, "A fine powder made by grinding grains, beans, or seeds.", "Flour" },
                    { 4, "A liquid fat extracted from olives, commonly used in cooking.", "Olive Oil" },
                    { 5, "A dairy product made by churning cream, often used for cooking or baking.", "Butter" },
                    { 6, "A pungent bulbous plant used as a seasoning in various cuisines.", "Garlic" },
                    { 7, "A vegetable with a strong, pungent taste used as a flavoring ingredient.", "Onion" },
                    { 8, "A red or yellowish fruit with a juicy pulp, commonly used in cooking.", "Tomato" },
                    { 9, "A domesticated bird commonly used for its meat in various recipes.", "Chicken" },
                    { 10, "The meat of cattle, often used for steaks, roasts, and other dishes.", "Beef" },
                    { 11, "A limbless aquatic creature commonly consumed as food.", "Fish" },
                    { 12, "A dough-based food commonly made from wheat flour.", "Pasta" },
                    { 13, "A cereal grain widely consumed as a staple food.", "Rice" },
                    { 14, "An opaque white liquid produced by the mammary glands of mammals.", "Milk" },
                    { 15, "A dairy product derived from milk, often used as a topping or ingredient.", "Cheese" },
                    { 16, "The oval reproductive bodies laid by female animals, often used in cooking.", "Eggs" },
                    { 17, "A leavening agent used in baking to make dough rise.", "Baking Powder" },
                    { 18, "A concentrated liquid flavoring made from vanilla beans.", "Vanilla Extract" },
                    { 19, "A fragrant spice derived from the bark of certain trees.", "Cinnamon" },
                    { 20, "A seedused as a spice, typically grated or ground.", "Nutmeg" },
                    { 21, "An aromatic herb commonly used in Mediterranean cuisine.", "Basil" },
                    { 22, "A herb with small aromatic leaves, often used in cooking.", "Thyme" },
                    { 23, "An evergreen herb with needle-like leaves, used for flavoring.", "Rosemary" },
                    { 24, "An herb with flat or curly leaves, commonly used as a garnish or flavoring.", "Parsley" },
                    { 25, "A yellow citrus fruit with acidic juice, used for its flavor and juice.", "Lemon" },
                    { 26, "A green citrus fruit with acidic juice, used for its flavor and juice.", "Lime" },
                    { 27, "A hot pepper used to add spiciness and flavor to dishes.", "Chili Pepper" },
                    { 28, "A ground spice made from dried red peppers, used for color and flavor.", "Paprika" },
                    { 29, "A condiment made from fermented soybeans, used for its savory flavor.", "Soy Sauce" },
                    { 30, "A sweet viscous substance produced by bees, used as a natural sweetener.", "Honey" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingridients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ingridients");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Ingridients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
