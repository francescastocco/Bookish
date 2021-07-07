using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookish.Migrations
{
    public partial class nullableColumns6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveBooks_BookTypes_BookTypeId",
                table: "LiveBooks");

            migrationBuilder.AlterColumn<int>(
                name: "BookTypeId",
                table: "LiveBooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LiveBooks_BookTypes_BookTypeId",
                table: "LiveBooks",
                column: "BookTypeId",
                principalTable: "BookTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LiveBooks_BookTypes_BookTypeId",
                table: "LiveBooks");

            migrationBuilder.AlterColumn<int>(
                name: "BookTypeId",
                table: "LiveBooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LiveBooks_BookTypes_BookTypeId",
                table: "LiveBooks",
                column: "BookTypeId",
                principalTable: "BookTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
