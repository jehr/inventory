using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModelProductAddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProducstBase_Categories_CategoryId",
                table: "ProducstBase");

            migrationBuilder.DropIndex(
                name: "IX_ProducstBase_CategoryId",
                table: "ProducstBase");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ProducstBase");

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "ProducstBase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProducstBase_SubCategoryId",
                table: "ProducstBase",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProducstBase_SubCategories_SubCategoryId",
                table: "ProducstBase",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProducstBase_SubCategories_SubCategoryId",
                table: "ProducstBase");

            migrationBuilder.DropIndex(
                name: "IX_ProducstBase_SubCategoryId",
                table: "ProducstBase");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "ProducstBase");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ProducstBase",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProducstBase_CategoryId",
                table: "ProducstBase",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProducstBase_Categories_CategoryId",
                table: "ProducstBase",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
