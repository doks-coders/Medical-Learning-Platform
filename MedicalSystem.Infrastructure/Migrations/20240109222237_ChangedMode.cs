using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedMode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileUrl",
                table: "NoteFiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FileUrl",
                table: "AssignmentFiles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 23, 22, 34, 974, DateTimeKind.Local).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 23, 22, 34, 974, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 23, 22, 34, 974, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 23, 22, 34, 974, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 23, 22, 34, 974, DateTimeKind.Local).AddTicks(4813));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileUrl",
                table: "NoteFiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FileUrl",
                table: "AssignmentFiles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
