using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LafargeApp.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgeOfReadingSeconds = table.Column<int>(type: "int", nullable: false),
                    AssetId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AltitudeMetres = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Heading = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    IsAvl = table.Column<int>(type: "int", nullable: false),
                    OdometerKilometres = table.Column<int>(type: "int", nullable: false),
                    Longitute = table.Column<double>(type: "float", nullable: false),
                    Hdop = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pdop = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<int>(type: "int", nullable: false),
                    SpeedKilometresPerHour = table.Column<int>(type: "int", nullable: false),
                    SpeedLimit = table.Column<int>(type: "int", nullable: false),
                    Vdop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AssetId = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastPositionTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitute = table.Column<double>(type: "float", nullable: false),
                    CurrentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}
