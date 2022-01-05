using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirLIine_MVC.Migrations
{
    public partial class airLine1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAirline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mabda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maghsad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tarikh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    saat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    zarfiat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodeMeli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblPlans");

            migrationBuilder.DropTable(
                name: "TblReservations");

            migrationBuilder.DropTable(
                name: "TblUsers");
        }
    }
}
