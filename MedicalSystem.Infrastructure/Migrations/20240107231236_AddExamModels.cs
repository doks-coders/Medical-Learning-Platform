using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddExamModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DateUploaded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamFiles_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "CourseName", "DateUploaded", "ExamName", "Year" },
                values: new object[,]
                {
                    { 1, "Anatomy", new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2858), "MED Anatomy 101", 2024 },
                    { 2, "Biochemistry", new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2865), "Med Biochem Exam", 2024 },
                    { 3, "Pathology", new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2867), "Pathology Board Exam", 2024 },
                    { 4, "Pharmacology", new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2869), "Pharmaceutical Licensing Exam", 2024 },
                    { 5, "Clinical Skills", new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2871), "Clinical Skills Assessment", 2024 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExamFiles_ExamId",
                table: "ExamFiles",
                column: "ExamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamFiles");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
