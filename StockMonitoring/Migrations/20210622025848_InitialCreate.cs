using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMonitoring.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterPieces",
                columns: table => new
                {
                    PartNumberId = table.Column<string>(type: "TEXT", nullable: false),
                    PiecePerKanban = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPieces", x => x.PartNumberId);
                });

            migrationBuilder.CreateTable(
                name: "ScanInputs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SectionCode = table.Column<int>(type: "INTEGER", nullable: false),
                    RegistDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PartNumberId = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanInputs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterPieces");

            migrationBuilder.DropTable(
                name: "ScanInputs");
        }
    }
}
