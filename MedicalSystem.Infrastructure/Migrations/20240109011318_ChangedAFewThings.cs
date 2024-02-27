using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedAFewThings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9721));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 8, 0, 12, 34, 997, DateTimeKind.Local).AddTicks(2871));
        }
    }
}
