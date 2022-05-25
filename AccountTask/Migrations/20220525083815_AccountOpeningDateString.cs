using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountTask.Migrations
{
    public partial class AccountOpeningDateString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OpeningDate",
                table: "Accounts",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpeningDate",
                table: "Accounts");
        }
    }
}
