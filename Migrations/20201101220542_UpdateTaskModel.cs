using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace todolist_api.Migrations
{
    public partial class UpdateTaskModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Task");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "Task",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Task",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Task");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
