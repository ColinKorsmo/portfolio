using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab_8_ColinKorsmo.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    AdmitDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SymptomDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "AdmitDate", "FirstName", "LastName", "SymptomDescription" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samantha", "Carter", "Severe migraines, Erratic behavior" },
                    { 2, new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "O'Neill", "Hallucinations, Memory loss" },
                    { 3, new DateTime(2024, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Jackson", "Seizures, Extreme mood swings" },
                    { 4, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "George", "Hammond", "Loss of motor control, Speech difficulties" },
                    { 5, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janet", "Fraiser", "Persistent dizziness, Glows in the dark" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
