using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Normy.Migrations
{
    /// <inheritdoc />
    public partial class FixTimeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wyroby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumerWyrobu = table.Column<string>(type: "TEXT", nullable: false),
                    NumerOperacji = table.Column<string>(type: "TEXT", nullable: false),
                    NumerMaszyny = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    WyliczonaNorma = table.Column<double>(type: "REAL", nullable: true),
                    DataUtworzenia = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wyroby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pomiary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WyrobId = table.Column<int>(type: "INTEGER", nullable: false),
                    Typ = table.Column<int>(type: "INTEGER", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Zmiana = table.Column<string>(type: "TEXT", nullable: false),
                    Pracownik = table.Column<string>(type: "TEXT", nullable: false),
                    GodzinaStart = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GodzinaStop = table.Column<DateTime>(type: "TEXT", nullable: true),
                    LicznikStart = table.Column<int>(type: "INTEGER", nullable: false),
                    LicznikStop = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pomiary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pomiary_Wyroby_WyrobId",
                        column: x => x.WyrobId,
                        principalTable: "Wyroby",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PomiaryCzasu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PomiarId = table.Column<int>(type: "INTEGER", nullable: false),
                    Numer = table.Column<int>(type: "INTEGER", nullable: false),
                    Czas = table.Column<double>(type: "REAL", nullable: false),
                    Uwagi = table.Column<string>(type: "TEXT", nullable: false),
                    Wykluczony = table.Column<bool>(type: "INTEGER", nullable: false),
                    DodatkowaCzynnosc = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PomiaryCzasu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PomiaryCzasu_Pomiary_PomiarId",
                        column: x => x.PomiarId,
                        principalTable: "Pomiary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pomiary_WyrobId",
                table: "Pomiary",
                column: "WyrobId");

            migrationBuilder.CreateIndex(
                name: "IX_PomiaryCzasu_PomiarId",
                table: "PomiaryCzasu",
                column: "PomiarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PomiaryCzasu");

            migrationBuilder.DropTable(
                name: "Pomiary");

            migrationBuilder.DropTable(
                name: "Wyroby");
        }
    }
}
