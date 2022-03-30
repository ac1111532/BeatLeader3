using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatLeader3.Migrations
{
    public partial class ViewsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountAge = table.Column<int>(type: "int", nullable: false),
                    PlayerHMD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerPlatform = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modcount = table.Column<int>(type: "int", nullable: false),
                    LevelsBeaten = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
