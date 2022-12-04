using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryGrabber.Migrations
{
    public partial class CreateAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroceryList",
                keyColumn: "id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GroceryList",
                columns: new[] { "id", "GroceryId", "ItemGroceryId", "UserID", "UserId" },
                values: new object[] { 1, 1, null, 1, null });
        }
    }
}
