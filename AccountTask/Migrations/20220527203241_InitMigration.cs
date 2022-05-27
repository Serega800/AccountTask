using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountTask.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Locality = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    Building = table.Column<string>(type: "TEXT", nullable: false),
                    ApartmentNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    Area = table.Column<string>(type: "TEXT", nullable: false),
                    ResidentsNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    OpeningDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: false),
                    ClosingDate = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    IsActive = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
