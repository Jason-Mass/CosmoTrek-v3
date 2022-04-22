using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CosmoTrek_v3.Data.Migrations
{
    public partial class ModelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "TrekPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RocketType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LaunchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mode = table.Column<bool>(type: "bit", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrekPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrekReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravelerName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Zip = table.Column<short>(type: "smallint", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpaceTravelUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrekPlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrekReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrekReservations_AspNetUsers_SpaceTravelUserId",
                        column: x => x.SpaceTravelUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrekReservations_TrekPlans_TrekPlanId",
                        column: x => x.TrekPlanId,
                        principalTable: "TrekPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrekReservations_SpaceTravelUserId",
                table: "TrekReservations",
                column: "SpaceTravelUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrekReservations_TrekPlanId",
                table: "TrekReservations",
                column: "TrekPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrekReservations");

            migrationBuilder.DropTable(
                name: "TrekPlans");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
