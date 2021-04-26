using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_Habit.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameHabit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeHabit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationHabit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habits");
        }
    }
}
