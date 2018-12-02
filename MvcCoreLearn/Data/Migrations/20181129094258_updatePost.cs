using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcCoreLearn.Data.Migrations
{
    public partial class updatePost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Readers",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Readers",
                table: "Posts",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
