using Microsoft.EntityFrameworkCore.Migrations;

namespace BeatLeader3.Migrations
{
    public partial class more : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beatmap_Score_ScoreID",
                table: "Beatmap");

            migrationBuilder.DropIndex(
                name: "IX_Beatmap_ScoreID",
                table: "Beatmap");

            migrationBuilder.DropColumn(
                name: "BeatmapID",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "ScoreID",
                table: "Beatmap");

            migrationBuilder.AddColumn<int>(
                name: "BeatmapID1",
                table: "Score",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Score_BeatmapID1",
                table: "Score",
                column: "BeatmapID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Beatmap_BeatmapID1",
                table: "Score",
                column: "BeatmapID1",
                principalTable: "Beatmap",
                principalColumn: "BeatmapID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Beatmap_BeatmapID1",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_BeatmapID1",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "BeatmapID1",
                table: "Score");

            migrationBuilder.AddColumn<int>(
                name: "BeatmapID",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoreID",
                table: "Beatmap",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beatmap_ScoreID",
                table: "Beatmap",
                column: "ScoreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Beatmap_Score_ScoreID",
                table: "Beatmap",
                column: "ScoreID",
                principalTable: "Score",
                principalColumn: "ScoreID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
