using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IDNumber = table.Column<int>(type: "int", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountTypeId = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    accountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountId = table.Column<int>(type: "int", nullable: false),
                    tripScheduleId = table.Column<int>(type: "int", nullable: false),
                    paymentId = table.Column<int>(type: "int", nullable: false),
                    numOfTickets = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cardNo = table.Column<int>(type: "int", nullable: false),
                    expiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cvv = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<float>(type: "real", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departureTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arrivalTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tripGroupId = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Trains",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainNo = table.Column<int>(type: "int", nullable: false),
                    numberOfSeats = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trains", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TripGroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    tripType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TripPrices",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tripPrice = table.Column<float>(type: "real", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripPrices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tripPriceId = table.Column<int>(type: "int", nullable: false),
                    departureStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arrivalStation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numberOfStops = table.Column<int>(type: "int", nullable: false),
                    tripGroupId = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TripSchedules",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tripId = table.Column<int>(type: "int", nullable: false),
                    scheduleId = table.Column<int>(type: "int", nullable: false),
                    trainId = table.Column<int>(type: "int", nullable: false),
                    tripStatusId = table.Column<int>(type: "int", nullable: false),
                    numberOfSeats = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripSchedules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TripStations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tripId = table.Column<int>(type: "int", nullable: false),
                    stationId = table.Column<int>(type: "int", nullable: false),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TripStatuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripStatuses", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Trains");

            migrationBuilder.DropTable(
                name: "TripGroups");

            migrationBuilder.DropTable(
                name: "TripPrices");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "TripSchedules");

            migrationBuilder.DropTable(
                name: "TripStations");

            migrationBuilder.DropTable(
                name: "TripStatuses");
        }
    }
}
