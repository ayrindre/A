using Microsoft.EntityFrameworkCore.Migrations;

namespace AirLIine_MVC.Migrations
{
    public partial class airLine5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodeSms",
                table: "TblUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodeSms",
                table: "TblUsers");
        }
    }
}
