using Microsoft.EntityFrameworkCore.Migrations;

namespace VaVuBaku.Migrations.Admin
{
    public partial class sdfsdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Products_ProductId",
                table: "Meals");

            migrationBuilder.DropIndex(
                name: "IX_Meals_ProductId",
                table: "Meals");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Meals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Meals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ProductId",
                table: "Meals",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Products_ProductId",
                table: "Meals",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
