using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class addedRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "572389a7-62bb-45de-9a96-edd501b0d498", "3", "HR", "HR" },
                    { "891aa57a-a0c1-45c6-8acd-e64791f5c112", "2", "User", "User" },
                    { "b8ae5297-fe52-43b0-a194-5fe9f2f182ba", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "572389a7-62bb-45de-9a96-edd501b0d498");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "891aa57a-a0c1-45c6-8acd-e64791f5c112");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8ae5297-fe52-43b0-a194-5fe9f2f182ba");
        }
    }
}
