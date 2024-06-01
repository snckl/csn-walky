using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Walky.API.Migrations
{
    /// <inheritdoc />
    public partial class FixedWalkDomainName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WalkImagegeUrl",
                table: "Walks",
                newName: "WalkImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WalkImageUrl",
                table: "Walks",
                newName: "WalkImagegeUrl");
        }
    }
}
