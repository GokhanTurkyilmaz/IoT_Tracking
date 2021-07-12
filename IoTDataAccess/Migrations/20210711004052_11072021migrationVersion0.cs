using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IoTDataAccess.Migrations
{
    public partial class _11072021migrationVersion0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EPCNO = table.Column<string>(type: "TEXT", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyLogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false),
                    TCNo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DeviceAddress = table.Column<int>(type: "INTEGER", nullable: false),
                    DeviceName = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceMacAddress = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceIPAddres = table.Column<string>(type: "TEXT", nullable: true),
                    DevicePortNo = table.Column<string>(type: "TEXT", nullable: true),
                    DeviceTopic = table.Column<string>(type: "TEXT", nullable: true),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Devices_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehicleModelName = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleModelYear = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleType = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleColor = table.Column<string>(type: "TEXT", nullable: true),
                    VehiclePlaque = table.Column<string>(type: "TEXT", nullable: true),
                    PersonID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EPCNO = table.Column<string>(type: "TEXT", nullable: true),
                    VehicleId = table.Column<int>(type: "INTEGER", nullable: false),
                    PersonID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tags_Persons_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Persons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tags_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_PersonId",
                table: "Devices",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_PersonID",
                table: "Tags",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_VehicleId",
                table: "Tags",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_PersonID",
                table: "Vehicles",
                column: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyLogs");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
