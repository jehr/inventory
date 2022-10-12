using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModelsProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateEndLicingh",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEndLicingh",
                table: "IntoInventories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Iva",
                table: "IntoInventories",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PriceBill",
                table: "IntoInventories",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Property",
                table: "IntoInventories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeProduct",
                table: "IntoInventories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateEndLicingh",
                table: "IntoInventories");

            migrationBuilder.DropColumn(
                name: "Iva",
                table: "IntoInventories");

            migrationBuilder.DropColumn(
                name: "PriceBill",
                table: "IntoInventories");

            migrationBuilder.DropColumn(
                name: "Property",
                table: "IntoInventories");

            migrationBuilder.DropColumn(
                name: "TypeProduct",
                table: "IntoInventories");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEndLicingh",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
