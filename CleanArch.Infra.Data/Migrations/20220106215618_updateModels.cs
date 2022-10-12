using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "TypesAssignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "TypeProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "SubCategories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "StateProduct",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Models",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "TypesAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "TypeProduct");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "StateProduct");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Categories");
        }
    }
}
