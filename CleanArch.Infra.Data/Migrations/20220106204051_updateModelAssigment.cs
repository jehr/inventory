using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModelAssigment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedBy",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCreatedByName",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedByName",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Assignments",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                table: "Assignments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "LastCreatedByName",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedByName",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Assignments");
        }
    }
}
