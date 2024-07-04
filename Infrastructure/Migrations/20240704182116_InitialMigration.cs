using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations;

/// <inheritdoc />
public partial class InitialMigration : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Composition",
            columns: table => new
            {
                CompositionId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                HeroesInfo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                AuthorId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Composition", x => x.CompositionId);
            });

        migrationBuilder.CreateTable(
            name: "Theater",
            columns: table => new
            {
                TheaterId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                FirstOpenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                OpenTime = table.Column<TimeOnly>(type: "time", nullable: false),
                CloseTime = table.Column<TimeOnly>(type: "time", nullable: false),
                Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Theater", x => x.TheaterId);
            });

        migrationBuilder.CreateTable(
            name: "Author",
            columns: table => new
            {
                AuthorId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                BirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                CompositionId = table.Column<int>(type: "int", nullable: false),
                TheaterId = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Author", x => x.AuthorId);
                table.ForeignKey(
                    name: "FK_Author_Composition_CompositionId",
                    column: x => x.CompositionId,
                    principalTable: "Composition",
                    principalColumn: "CompositionId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Author_Theater_TheaterId",
                    column: x => x.TheaterId,
                    principalTable: "Theater",
                    principalColumn: "TheaterId");
            });

        migrationBuilder.CreateTable(
            name: "Play",
            columns: table => new
            {
                PlayId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                StartDateTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                EndDateTimeUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                Price = table.Column<int>(type: "int", nullable: false),
                Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                TheaterId = table.Column<int>(type: "int", nullable: false),
                CompositionId = table.Column<int>(type: "int", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Play", x => x.PlayId);
                table.ForeignKey(
                    name: "FK_Play_Composition_CompositionId",
                    column: x => x.CompositionId,
                    principalTable: "Composition",
                    principalColumn: "CompositionId",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Play_Theater_TheaterId",
                    column: x => x.TheaterId,
                    principalTable: "Theater",
                    principalColumn: "TheaterId",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Author_CompositionId",
            table: "Author",
            column: "CompositionId");

        migrationBuilder.CreateIndex(
            name: "IX_Author_TheaterId",
            table: "Author",
            column: "TheaterId");

        migrationBuilder.CreateIndex(
            name: "IX_Play_CompositionId",
            table: "Play",
            column: "CompositionId");

        migrationBuilder.CreateIndex(
            name: "IX_Play_TheaterId",
            table: "Play",
            column: "TheaterId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Author");

        migrationBuilder.DropTable(
            name: "Play");

        migrationBuilder.DropTable(
            name: "Composition");

        migrationBuilder.DropTable(
            name: "Theater");
    }
}
