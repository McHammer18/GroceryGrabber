using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryGrabber.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroceryItems",
                columns: table => new
                {
                    GroceryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroceryItems", x => x.GroceryId);
                });

            migrationBuilder.InsertData(
                table: "GroceryItems",
                columns: new[] { "GroceryId", "Department", "Description", "Location", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Meat", "Role of ground Hamburger Meat", "Meat Counter/ Aisle 65", "1lbs Hamburger", 0f },
                    { 2, "Produce", "1 Head of Iceburg Lettuce", "Aisle 42", "Lettuce", 0f },
                    { 3, "Produce", "5 lbs bag of Honey Crisp", "Aisle 44", "Apples", 0f },
                    { 4, "Deli", "1 lbs of Turkey slices", "Deli Counter/ Aisle 55", "Sliced Turkey", 0f },
                    { 5, "Bakery", "1 loaf of White Whole Grain", "Aisle 20", "Bread", 0f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroceryItems");
        }
    }
}
