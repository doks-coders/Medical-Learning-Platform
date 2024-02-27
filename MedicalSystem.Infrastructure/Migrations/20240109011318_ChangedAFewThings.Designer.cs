﻿// <auto-generated />
using System;
using MedicalSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicalSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240109011318_ChangedAFewThings")]
    partial class ChangedAFewThings
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicalSystem.Models.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Anatomy",
                            DateUploaded = new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9700),
                            ExamName = "MED Anatomy 101",
                            Year = 2024
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Biochemistry",
                            DateUploaded = new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9714),
                            ExamName = "Med Biochem Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Pathology",
                            DateUploaded = new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9716),
                            ExamName = "Pathology Board Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Pharmacology",
                            DateUploaded = new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9719),
                            ExamName = "Pharmaceutical Licensing Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Clinical Skills",
                            DateUploaded = new DateTime(2024, 1, 9, 2, 13, 16, 114, DateTimeKind.Local).AddTicks(9721),
                            ExamName = "Clinical Skills Assessment",
                            Year = 2024
                        });
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.ExamFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("FileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamFiles");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.ExamFile", b =>
                {
                    b.HasOne("MedicalSystem.Models.Models.Exam", "Exam")
                        .WithMany("ExamFiles")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Exam", b =>
                {
                    b.Navigation("ExamFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
