using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class updateModelsInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailsInto_IntoInventories_IntoInventoryId",
                table: "DetailsInto");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailsInto_Products_ProductId",
                table: "DetailsInto");

            migrationBuilder.DropForeignKey(
                name: "FK_DetaislOut_Products_ProductId",
                table: "DetaislOut");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryInventories_Products_ProductId",
                table: "HistoryInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_IntoInventories_Campus_CampusId",
                table: "IntoInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_IntoInventories_Suppliers_SupplierId",
                table: "IntoInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OutInventories_Campus_CampusId",
                table: "OutInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StateProduct_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Marks_MarkId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MarkId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateProductId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CampusId",
                table: "OutInventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IntoInventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CampusId",
                table: "IntoInventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "HistoryInventories",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DetaislOut",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IntoInventoryId",
                table: "DetaislOut",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DetailsInto",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IntoInventoryId",
                table: "DetailsInto",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TypeAssignmentId",
                table: "Assignments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_StateProductId",
                table: "Products",
                column: "StateProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments",
                column: "TypeAssignmentId",
                principalTable: "TypesAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsInto_IntoInventories_IntoInventoryId",
                table: "DetailsInto",
                column: "IntoInventoryId",
                principalTable: "IntoInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsInto_Products_ProductId",
                table: "DetailsInto",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetaislOut_Products_ProductId",
                table: "DetaislOut",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryInventories_Products_ProductId",
                table: "HistoryInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntoInventories_Campus_CampusId",
                table: "IntoInventories",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IntoInventories_Suppliers_SupplierId",
                table: "IntoInventories",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutInventories_Campus_CampusId",
                table: "OutInventories",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Marks_MarkId",
                table: "Products",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StateProduct_StateProductId",
                table: "Products",
                column: "StateProductId",
                principalTable: "StateProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailsInto_IntoInventories_IntoInventoryId",
                table: "DetailsInto");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailsInto_Products_ProductId",
                table: "DetailsInto");

            migrationBuilder.DropForeignKey(
                name: "FK_DetaislOut_Products_ProductId",
                table: "DetaislOut");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoryInventories_Products_ProductId",
                table: "HistoryInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_IntoInventories_Campus_CampusId",
                table: "IntoInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_IntoInventories_Suppliers_SupplierId",
                table: "IntoInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OutInventories_Campus_CampusId",
                table: "OutInventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Marks_MarkId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_StateProduct_StateProductId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_Products_StateProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StateProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IntoInventoryId",
                table: "DetaislOut");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ModelId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MarkId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CampusId",
                table: "OutInventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "IntoInventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CampusId",
                table: "IntoInventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "HistoryInventories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DetaislOut",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "DetailsInto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IntoInventoryId",
                table: "DetailsInto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TypeAssignmentId",
                table: "Assignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_TypesAssignments_TypeAssignmentId",
                table: "Assignments",
                column: "TypeAssignmentId",
                principalTable: "TypesAssignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsInto_IntoInventories_IntoInventoryId",
                table: "DetailsInto",
                column: "IntoInventoryId",
                principalTable: "IntoInventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailsInto_Products_ProductId",
                table: "DetailsInto",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DetaislOut_Products_ProductId",
                table: "DetaislOut",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoryInventories_Products_ProductId",
                table: "HistoryInventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IntoInventories_Campus_CampusId",
                table: "IntoInventories",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IntoInventories_Suppliers_SupplierId",
                table: "IntoInventories",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutInventories_Campus_CampusId",
                table: "OutInventories",
                column: "CampusId",
                principalTable: "Campus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_StateProduct_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "StateProduct",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Marks_MarkId",
                table: "Products",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Models_ModelId",
                table: "Products",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
