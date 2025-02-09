using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreBlogV1.WebUI.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsStatusColumnToBlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsStatus",
                table: "Blogs",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsStatus",
                table: "Blogs");
        }
    }
}
