using Microsoft.EntityFrameworkCore.Migrations;

namespace todolist_api.Migrations
{
    public partial class UpdateTaskModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Done",
                table: "Task");

            migrationBuilder.AddColumn<bool>(
                name: "Important",
                table: "Task",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Important",
                table: "Task");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Task",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
