using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGameListBackend.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genre_GenreId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platform_PlatformId",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker");

            migrationBuilder.RenameColumn(
                name: "PlatformId",
                table: "GamePlatform",
                newName: "PlatformsId");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_PlatformId",
                table: "GamePlatform",
                newName: "IX_GamePlatform_PlatformsId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GameGenre",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_GameGenre_GenreId",
                table: "GameGenre",
                newName: "IX_GameGenre_GenresId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Tracker",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "GameTracker",
                columns: table => new
                {
                    GamesId = table.Column<int>(type: "INTEGER", nullable: false),
                    TrackersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTracker", x => new { x.GamesId, x.TrackersId });
                    table.ForeignKey(
                        name: "FK_GameTracker_Game_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Game",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameTracker_Tracker_TrackersId",
                        column: x => x.TrackersId,
                        principalTable: "Tracker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameTracker_TrackersId",
                table: "GameTracker",
                column: "TrackersId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genre_GenresId",
                table: "GameGenre",
                column: "GenresId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platform_PlatformsId",
                table: "GamePlatform",
                column: "PlatformsId",
                principalTable: "Platform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genre_GenresId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platform_PlatformsId",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker");

            migrationBuilder.DropTable(
                name: "GameTracker");

            migrationBuilder.RenameColumn(
                name: "PlatformsId",
                table: "GamePlatform",
                newName: "PlatformId");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_PlatformsId",
                table: "GamePlatform",
                newName: "IX_GamePlatform_PlatformId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GameGenre",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GameGenre_GenresId",
                table: "GameGenre",
                newName: "IX_GameGenre_GenreId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Tracker",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genre_GenreId",
                table: "GameGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platform_PlatformId",
                table: "GamePlatform",
                column: "PlatformId",
                principalTable: "Platform",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tracker_Users_UserId",
                table: "Tracker",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
