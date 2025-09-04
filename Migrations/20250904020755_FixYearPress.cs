using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fulent_API.Migrations
{
    /// <inheritdoc />
    public partial class FixYearPress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearPress",
                table: "Books",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearPress",
                table: "Books");
        }

    }
}
