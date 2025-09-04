using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fulent_API.Migrations
{
    /// <inheritdoc />
    public partial class AddIdToTCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "T_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "T_Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "T_Cards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "S_Cards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "S_Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "S_Cards",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_T_Cards",
                table: "T_Cards",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_S_Cards",
                table: "S_Cards",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_T_Cards",
                table: "T_Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_S_Cards",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "T_Cards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "S_Cards");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "S_Cards");
        }
    }
}
