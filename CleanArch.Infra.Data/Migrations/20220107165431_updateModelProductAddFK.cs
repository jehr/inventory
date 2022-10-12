using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModelProductAddFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductBaseId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductBaseId",
                table: "Products",
                column: "ProductBaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProducstBase_ProductBaseId",
                table: "Products",
                column: "ProductBaseId",
                principalTable: "ProducstBase",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProducstBase_ProductBaseId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductBaseId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductBaseId",
                table: "Products");
        }
    }
}
