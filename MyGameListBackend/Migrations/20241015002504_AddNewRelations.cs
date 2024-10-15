using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyGameListBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddNewRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackerUser");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Tracker",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tracker_UsersId",
                table: "Tracker",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracker_Users_UsersId",
                table: "Tracker",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracker_Users_UsersId",
                table: "Tracker");

            migrationBuilder.DropIndex(
                name: "IX_Tracker_UsersId",
                table: "Tracker");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Tracker");

            migrationBuilder.CreateTable(
                name: "TrackerUser",
                columns: table => new
                {
                    TrackerId = table.Column<int>(type: "INTEGER", nullable: false),
                    UsersId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackerUser", x => new { x.TrackerId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_TrackerUser_Tracker_TrackerId",
                        column: x => x.TrackerId,
                        principalTable: "Tracker",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackerUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackerUser_UsersId",
                table: "TrackerUser",
                column: "UsersId");
        }
    }
}
