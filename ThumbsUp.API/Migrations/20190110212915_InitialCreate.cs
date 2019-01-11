using Microsoft.EntityFrameworkCore.Migrations;

namespace ThumbsUp.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        // Contains all the information entity frame needs to create the database or change it
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });
        }

            // When we want to rollback to a migrationsthat has been applied to the database will drop the table
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Values");
        }
    }
}
