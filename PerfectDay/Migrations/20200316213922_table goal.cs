using Microsoft.EntityFrameworkCore.Migrations;

namespace PerfectDay.Migrations
{
    public partial class tablegoal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_goals",
                table: "goals");

            migrationBuilder.RenameTable(
                name: "goals",
                newName: "Goals");

            migrationBuilder.AddColumn<int>(
                name: "Deadline",
                table: "Goals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GoalDescription",
                table: "Goals",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Goals",
                table: "Goals",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Goals",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "Deadline",
                table: "Goals");

            migrationBuilder.DropColumn(
                name: "GoalDescription",
                table: "Goals");

            migrationBuilder.RenameTable(
                name: "Goals",
                newName: "goals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_goals",
                table: "goals",
                column: "Id");
        }
    }
}
