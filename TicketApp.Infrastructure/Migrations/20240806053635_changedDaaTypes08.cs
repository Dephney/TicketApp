using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changedDaaTypes08 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "TripStatuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TripStations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TripSchedules",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Trips",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TripPrices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TripGroups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Trains",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Stations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Schedules",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Payments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Bookings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "AccountTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Accounts",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "IDNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripStatuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripStations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripSchedules",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trips",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripPrices",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripGroups",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trains",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schedules",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Payments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Bookings",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountTypes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Accounts",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "phone",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IDNumber",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
