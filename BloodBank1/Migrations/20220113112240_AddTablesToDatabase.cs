using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodBank1.Migrations
{
    public partial class AddTablesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    LastVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodRecived = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isVaccinate = table.Column<bool>(type: "bit", nullable: false),
                    BloodId = table.Column<int>(type: "int", nullable: false),
                    OrgId = table.Column<int>(type: "int", nullable: false),
                    HemoglobinId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BloodNames",
                columns: table => new
                {
                    BloodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodNames", x => x.BloodId);
                });

            migrationBuilder.CreateTable(
                name: "Hemoglobins",
                columns: table => new
                {
                    HemoglobinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HemoglobinLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hemoglobins", x => x.HemoglobinId);
                });

            migrationBuilder.CreateTable(
                name: "Kindoforgi",
                columns: table => new
                {
                    OrgId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kindoforgi", x => x.OrgId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodDetails");

            migrationBuilder.DropTable(
                name: "BloodNames");

            migrationBuilder.DropTable(
                name: "Hemoglobins");

            migrationBuilder.DropTable(
                name: "Kindoforgi");
        }
    }
}
