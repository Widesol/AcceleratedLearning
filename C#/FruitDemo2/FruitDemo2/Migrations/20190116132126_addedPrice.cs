using Microsoft.EntityFrameworkCore.Migrations;

namespace FruitDemo2.Migrations
{
    public partial class addedPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_FruitCategory_CategoryId",
                table: "Fruits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FruitCategory",
                table: "FruitCategory");

            migrationBuilder.RenameTable(
                name: "FruitCategory",
                newName: "Categorys");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Fruits",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_Categorys_CategoryId",
                table: "Fruits",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fruits_Categorys_CategoryId",
                table: "Fruits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Fruits");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "FruitCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FruitCategory",
                table: "FruitCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fruits_FruitCategory_CategoryId",
                table: "Fruits",
                column: "CategoryId",
                principalTable: "FruitCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
