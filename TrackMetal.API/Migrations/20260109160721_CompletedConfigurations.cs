using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMetal.API.Migrations
{
    /// <inheritdoc />
    public partial class CompletedConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corners_Tracks_TrackId",
                table: "Corners");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Cars_CarId",
                table: "Setups");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Tracks_TrackId",
                table: "Setups");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tracks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Tracks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CircuitType",
                table: "Tracks",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "LapRecord",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Aero",
                table: "Setups",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Corners",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OfficialName",
                table: "Corners",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Corners",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CommunityPosts",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CommunityPosts",
                type: "text",
                maxLength: 4096,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "CommunityPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CommunityComments",
                type: "text",
                maxLength: 4096,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeStamp",
                table: "CommunityComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LapTimes_TrackId",
                table: "LapTimes",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_CommunityComments_CommunityPostId",
                table: "CommunityComments",
                column: "CommunityPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Comment",
                table: "CommunityComments",
                column: "CommunityPostId",
                principalTable: "CommunityPosts",
                principalColumn: "CommunityPostId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Corner",
                table: "Corners",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_LapTime",
                table: "LapTimes",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Setup",
                table: "Setups",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Track_Setup",
                table: "Setups",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Comment",
                table: "CommunityComments");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Corner",
                table: "Corners");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_LapTime",
                table: "LapTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_Setup",
                table: "Setups");

            migrationBuilder.DropForeignKey(
                name: "FK_Track_Setup",
                table: "Setups");

            migrationBuilder.DropIndex(
                name: "IX_LapTimes_TrackId",
                table: "LapTimes");

            migrationBuilder.DropIndex(
                name: "IX_CommunityComments_CommunityPostId",
                table: "CommunityComments");

            migrationBuilder.DropColumn(
                name: "LapRecord",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "CommunityPosts");

            migrationBuilder.DropColumn(
                name: "TimeStamp",
                table: "CommunityComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cars");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CircuitType",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Aero",
                table: "Setups",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Corners",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "OfficialName",
                table: "Corners",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Corners",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "CommunityPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CommunityPosts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 4096);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "CommunityComments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 4096);

            migrationBuilder.AddForeignKey(
                name: "FK_Corners_Tracks_TrackId",
                table: "Corners",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Cars_CarId",
                table: "Setups",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Tracks_TrackId",
                table: "Setups",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "TrackId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
