using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Walky.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedTheDifficulties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39dbc1e0-2bf5-4c3e-8251-8ddf9e277a15"), "Easy" },
                    { new Guid("e93be645-6021-4e41-8ef0-31a36adf350d"), "Medium" },
                    { new Guid("ed18c14b-9732-4741-b245-2692e593d828"), "Hard" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("39dbc1e0-2bf5-4c3e-8251-8ddf9e277a15"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e93be645-6021-4e41-8ef0-31a36adf350d"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("ed18c14b-9732-4741-b245-2692e593d828"));
        }
    }
}
