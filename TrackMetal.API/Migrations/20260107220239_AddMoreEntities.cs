using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMetal.API.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommunityComments",
                columns: table => new
                {
                    CommunityCommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunityPostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityComments", x => x.CommunityCommentsId);
                });

            migrationBuilder.CreateTable(
                name: "CommunityPosts",
                columns: table => new
                {
                    CommunityPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityPosts", x => x.CommunityPostId);
                });

            migrationBuilder.CreateTable(
                name: "LapTimes",
                columns: table => new
                {
                    LapTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TrackId = table.Column<int>(type: "int", nullable: false),
                    LapTimeInSeconds = table.Column<int>(type: "int", nullable: false),
                    Sector1TimeInSeconds = table.Column<int>(type: "int", nullable: false),
                    Sector2TimeInSeconds = table.Column<int>(type: "int", nullable: false),
                    Sector3TimeInSeconds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LapTimes", x => x.LapTimeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    SafetyRating = table.Column<int>(type: "int", nullable: false),
                    ExperienceRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunityComments");

            migrationBuilder.DropTable(
                name: "CommunityPosts");

            migrationBuilder.DropTable(
                name: "LapTimes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
