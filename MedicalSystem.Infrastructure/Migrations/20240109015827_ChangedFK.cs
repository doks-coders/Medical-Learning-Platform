using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangedFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 58, 25, 665, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 58, 25, 665, DateTimeKind.Local).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 58, 25, 665, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 58, 25, 665, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUploaded",
                value: new DateTime(2024, 1, 9, 2, 58, 25, 665, DateTimeKind.Local).AddTicks(3695));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
