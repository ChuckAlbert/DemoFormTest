using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoFormTest.Migrations
{
    public partial class Teams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamsNo = table.Column<string>(maxLength: 5, nullable: false),
                    TeamsName = table.Column<string>(maxLength: 20, nullable: false),
                    SumOfPersons = table.Column<int>(maxLength: 3, nullable: false),
                    SalaryOfTeams = table.Column<double>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
