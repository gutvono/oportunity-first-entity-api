using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OportunityApi.Migrations
{
    /// <inheritdoc />
    public partial class Oportunity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oportunity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutbreakLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursQty = table.Column<int>(type: "int", nullable: false),
                    ErrorsQty = table.Column<int>(type: "int", nullable: false),
                    LearningLevel = table.Column<long>(type: "bigint", nullable: false),
                    SleepingHours = table.Column<long>(type: "bigint", nullable: false),
                    HoursOff = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oportunity", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oportunity");
        }
    }
}
