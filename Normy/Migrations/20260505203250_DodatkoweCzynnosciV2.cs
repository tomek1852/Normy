using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Normy.Migrations
{
    /// <inheritdoc />
    public partial class DodatkoweCzynnosciV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DodatkoweCzynnosci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WyrobId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    CoIleSztuk = table.Column<int>(type: "INTEGER", nullable: false),
                    Pomiar1 = table.Column<double>(type: "REAL", nullable: false),
                    Pomiar2 = table.Column<double>(type: "REAL", nullable: false),
                    Pomiar3 = table.Column<double>(type: "REAL", nullable: false),
                    Pomiar4 = table.Column<double>(type: "REAL", nullable: false),
                    Pomiar5 = table.Column<double>(type: "REAL", nullable: false),
                    WybranaCzynnoscZPomiarow = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DodatkoweCzynnosci", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DodatkoweCzynnosci");
        }
    }
}
