using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoWorld.Migrations
{
    public partial class ChangeTheManufacturedDateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturedDate",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "ManufacturedMonth",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufacturedYear",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturedMonth",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ManufacturedYear",
                table: "Cars");

            migrationBuilder.AddColumn<DateTime>(
                name: "ManufacturedDate",
                table: "Cars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
