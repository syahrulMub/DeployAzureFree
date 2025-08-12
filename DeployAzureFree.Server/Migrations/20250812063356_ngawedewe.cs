using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeployAzureFree.Server.Migrations
{
    /// <inheritdoc />
    public partial class ngawedewe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValue: new DateTime(2025, 8, 12, 13, 33, 56, 292, DateTimeKind.Local).AddTicks(9510))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}
