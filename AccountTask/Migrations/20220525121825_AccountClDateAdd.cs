using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountTask.Migrations
{
    public partial class AccountClDateAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ClosingDate",
                table: "Accounts",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClosingDate",
                table: "Accounts");
        }
    }
}
