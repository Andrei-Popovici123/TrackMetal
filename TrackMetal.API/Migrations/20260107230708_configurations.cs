using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackMetal.API.Migrations
{
    /// <inheritdoc />
    public partial class configurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Setups",
                newName: "Aero");

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Setups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Suspension",
                table: "Setups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TireId",
                table: "Setups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrackId",
                table: "Setups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OfficialName",
                table: "Corners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Sector",
                table: "Corners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TrackId",
                table: "Corners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Cars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Cars",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Setups_CarId",
                table: "Setups",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Setups_TrackId",
                table: "Setups",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Corners_TrackId",
                table: "Corners",
                column: "TrackId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Setups_CarId",
                table: "Setups");

            migrationBuilder.DropIndex(
                name: "IX_Setups_TrackId",
                table: "Setups");

            migrationBuilder.DropIndex(
                name: "IX_Corners_TrackId",
                table: "Corners");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Setups");

            migrationBuilder.DropColumn(
                name: "Suspension",
                table: "Setups");

            migrationBuilder.DropColumn(
                name: "TireId",
                table: "Setups");

            migrationBuilder.DropColumn(
                name: "TrackId",
                table: "Setups");

            migrationBuilder.DropColumn(
                name: "OfficialName",
                table: "Corners");

            migrationBuilder.DropColumn(
                name: "Sector",
                table: "Corners");

            migrationBuilder.DropColumn(
                name: "TrackId",
                table: "Corners");

            migrationBuilder.RenameColumn(
                name: "Aero",
                table: "Setups",
                newName: "Type");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
