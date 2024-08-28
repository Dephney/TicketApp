using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TripSchededulesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripSchedules");

        }
    }
}
