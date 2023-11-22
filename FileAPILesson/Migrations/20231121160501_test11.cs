using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FileAPILesson.Migrations
{
    /// <inheritdoc />
    public partial class test11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Teachers");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Teachers",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Teachers");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
