using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vlad_Irina_Lab2.Migrations
{
    public partial class CompleteUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "BookCategory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "BookCategory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID");
        }
    }
}
