using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleOverview.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surnames = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    CountryOfResidence = table.Column<string>(type: "TEXT", nullable: false),
                    Job = table.Column<string>(type: "TEXT", nullable: false),
                    IsSatisfiedWithWork = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrossAnnualSalary = table.Column<decimal>(type: "TEXT", nullable: false),
                    Currency = table.Column<string>(type: "TEXT", nullable: true),
                    IsSatisfiedWithSalary = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
