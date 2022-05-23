using Microsoft.EntityFrameworkCore.Migrations;

namespace AccountTask.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Accounts",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Accounts",
                newName: "Locality");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Accounts",
                newName: "ResidentsCount");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentNumber",
                table: "Accounts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Area",
                table: "Accounts",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Building",
                table: "Accounts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Case",
                table: "Accounts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Accounts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Accounts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "PropertyAddressId",
                table: "Accounts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_PropertyAddressId",
                table: "Accounts",
                column: "PropertyAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Accounts_PropertyAddressId",
                table: "Accounts",
                column: "PropertyAddressId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Accounts_PropertyAddressId",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_PropertyAddressId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Building",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Case",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "PropertyAddressId",
                table: "Accounts");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Accounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ResidentsCount",
                table: "Accounts",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "Locality",
                table: "Accounts",
                newName: "Manufacturer");
        }
    }
}
