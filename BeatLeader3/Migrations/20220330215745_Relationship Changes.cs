using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatLeader3.Migrations
{
    public partial class RelationshipChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Beatmap_SongID",
                table: "Beatmap");

            migrationBuilder.CreateIndex(
                name: "IX_Beatmap_SongID",
                table: "Beatmap",
                column: "SongID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Beatmap_SongID",
                table: "Beatmap");

            migrationBuilder.CreateIndex(
                name: "IX_Beatmap_SongID",
                table: "Beatmap",
                column: "SongID");
        }
    }
}
