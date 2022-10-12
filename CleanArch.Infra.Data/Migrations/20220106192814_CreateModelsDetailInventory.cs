using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class CreateModelsDetailInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Assignments_TypeAssignmentId",
                table: "Assignments");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments",
                column: "TypeAssignmentId",
                principalTable: "TypesAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Assignments_TypeAssignmentId",
                table: "Assignments",
                column: "TypeAssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
