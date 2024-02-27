using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LectureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUploaded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignmentFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssignmentFiles_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoteFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteFiles_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Study of the structure and organization of the body and its parts, including organs and tissues.", "Anatomy" },
                    { 2, "Exploration of the chemical processes and substances that occur within living organisms.", "Biochemistry" },
                    { 3, "Investigation of the nature and causes of diseases, including the examination of tissues, organs, and bodily fluids.", "Pathology" },
                    { 4, "Study of drugs and their interactions with living organisms, including their mechanisms of action and therapeutic uses.", "Pharmacology" },
                    { 5, "Development of practical abilities and techniques essential for healthcare professionals, including patient examination and communication.", "Clinical Skills" }
                });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentFiles_TopicId",
                table: "AssignmentFiles",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteFiles_TopicId",
                table: "NoteFiles",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_CourseId",
                table: "Topics",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentFiles");

            migrationBuilder.DropTable(
                name: "NoteFiles");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 3, 47, 22, 227, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 3, 47, 22, 227, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 3, 47, 22, 227, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 3, 47, 22, 227, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 3, 47, 22, 227, DateTimeKind.Local).AddTicks(7281));
        }
    }
}
