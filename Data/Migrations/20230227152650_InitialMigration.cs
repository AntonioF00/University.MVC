using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a7aaef4c-7efc-4dfb-84d4-2e90cfb89143"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Nickname", "Password", "Role", "Surname" },
                values: new object[] { new Guid("0b9e080c-6788-40a8-b591-8f1291b0dd34"), null, "Admin", null, "Admin", true, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0b9e080c-6788-40a8-b591-8f1291b0dd34"));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Name", "Nickname", "Password", "Role", "Surname" },
                values: new object[] { new Guid("a7aaef4c-7efc-4dfb-84d4-2e90cfb89143"), null, "Admin", null, "Admin", true, "Admin" });
        }
    }
}
