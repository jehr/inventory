using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class UpdateModelsDetailInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetailsInto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    LastCreatedByName = table.Column<string>(nullable: true),
                    LastUpdatedByName = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    PriceUnit = table.Column<double>(nullable: false),
                    IntoInventoryId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsInto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailsInto_IntoInventories_IntoInventoryId",
                        column: x => x.IntoInventoryId,
                        principalTable: "IntoInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailsInto_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetaislOut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<Guid>(nullable: true),
                    UpdatedBy = table.Column<Guid>(nullable: true),
                    LastCreatedByName = table.Column<string>(nullable: true),
                    LastUpdatedByName = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    PriceUnit = table.Column<double>(nullable: false),
                    OutInventoryId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetaislOut", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetaislOut_OutInventories_OutInventoryId",
                        column: x => x.OutInventoryId,
                        principalTable: "OutInventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetaislOut_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetailsInto_IntoInventoryId",
                table: "DetailsInto",
                column: "IntoInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailsInto_ProductId",
                table: "DetailsInto",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DetaislOut_OutInventoryId",
                table: "DetaislOut",
                column: "OutInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DetaislOut_ProductId",
                table: "DetaislOut",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailsInto");

            migrationBuilder.DropTable(
                name: "DetaislOut");
        }
    }
}
