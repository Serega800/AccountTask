using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountTask.Migrations
{
    public partial class AccountFieldsChanging1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Accounts",
                newName: "Locality");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Accounts",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Accounts",
                newName: "ApartmentNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Locality",
                table: "Accounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Accounts",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "ApartmentNumber",
                table: "Accounts",
                newName: "Capacity");
        }
    }
}
