using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryGrabber.Migrations
{
    public partial class UserList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "GroceryList",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    GroceryId = table.Column<int>(type: "int", nullable: false),
                    ItemGroceryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroceryList", x => x.id);
                    table.ForeignKey(
                        name: "FK_GroceryList_GroceryItems_ItemGroceryId",
                        column: x => x.ItemGroceryId,
                        principalTable: "GroceryItems",
                        principalColumn: "GroceryId");
                    table.ForeignKey(
                        name: "FK_GroceryList_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Password", "UserName" },
                values: new object[] { 1, "Morgan", "P@ssw0rd1", "MorganC" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Password", "UserName" },
                values: new object[] { 2, "Taylor", "P@ssw0rd1", "LadyLuck" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Name", "Password", "UserName" },
                values: new object[] { 3, "Deaon", "P@ssw0rd1", "DeonD" });

            migrationBuilder.InsertData(
                table: "GroceryList",
                columns: new[] { "id", "GroceryId", "ItemGroceryId", "UserID" },
                values: new object[] { 1, 1, null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_GroceryList_ItemGroceryId",
                table: "GroceryList",
                column: "ItemGroceryId");

            migrationBuilder.CreateIndex(
                name: "IX_GroceryList_UserID",
                table: "GroceryList",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroceryList");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
