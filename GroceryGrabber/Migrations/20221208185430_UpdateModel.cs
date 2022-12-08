using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryGrabber.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "item4",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "item3",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "item2",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "item1",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "item10",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item11",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item12",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item13",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item14",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item15",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item5",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item6",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item7",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item8",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "item9",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "item10",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item11",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item12",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item13",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item14",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item15",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item5",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item6",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item7",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item8",
                table: "GroceryViewModel");

            migrationBuilder.DropColumn(
                name: "item9",
                table: "GroceryViewModel");

            migrationBuilder.AlterColumn<string>(
                name: "item4",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "item3",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "item2",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "item1",
                table: "GroceryViewModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
