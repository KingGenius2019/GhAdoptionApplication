using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Chld = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ChildCode = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    KnownAs = table.Column<string>(type: "TEXT", nullable: true),
                    Sex = table.Column<string>(type: "Nvarchar(10)", nullable: true),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true),
                    StudyPath = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FoundRelinguished = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Intake = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "TEXT", nullable: true),
                    LegalRep = table.Column<string>(type: "TEXT", nullable: true),
                    Region = table.Column<string>(type: "Nvarchar(80)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Chld);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");
        }
    }
}
